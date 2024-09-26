using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapFontGenerator
{
    public partial class Form1 : Form
    {
        // Todo: upload to Github
        // Todo: add the transparent background
        // Todo: add more charsets

        List<string> fontNames;
        Dictionary<FontCacheKey, Bitmap> fontCache;
        string top32 = " \u263a\u263B\u2665\u2666\u2663\u2660\u2022" + 
            "\u25D8\u25CB\u25D9\u2642\u2640\u266A\u266B\u263C" +
            "\u25BA\u25C4\u2195\u203C\u00B6\u00A7\u25AC\u21A8" +
            "\u2191\u2193\u2192\u2190\u221F\u2194\u25B2\u25BC";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fontNames = new List<string>();
            fontCache = new Dictionary<FontCacheKey, Bitmap>();
            colourDialogue = new ColorDialog();

            foreach (var font in FontFamily.Families)
                fontNames.Add(font.Name);

            lsbFontList.Items.AddRange(fontNames.ToArray());

            Foreground = Color.Black;
            Background = Color.White;
        }

        ColorDialog colourDialogue;

        Color _foreground, _background;
        Color Foreground {
            get { return _foreground; }
            set {
                _foreground = value;
                btnForeground.BackColor = value; } }

        Color Background {
            get { return _background; }
            set {
                _background = value;
                btnBackground.BackColor = value; } }

        //int CharacterWidth {
        //    get { return (int)nudCharacterWidth.Value; }
        //    set { nudCharacterWidth.Value = value;  }
        //}

        //int CharacterHeight {
        //    get { return (int)nudCharacterHeight.Value; }
        //    set { nudCharacterHeight.Value = value; }
        //}

        string getFontName() { return lsbFontList.SelectedItem.ToString(); }
        int getFontSize() { return (int)nudFontSize.Value; }
        int getCharacterWidth() { return (int)nudCharacterWidth.Value; }
        int getCharacterHeight() { return (int)nudCharacterHeight.Value; }

        void regeneratePreview() {
            var fontName = getFontName();

            // Todo: foreground & background
            // Is caching really necessary?
            var newKey = new FontCacheKey(fontName, getFontSize(), getCharacterWidth(), getCharacterHeight());

            if (!fontCache.ContainsKey(newKey)) {
                lblFontName.Text = fontName;

                var bmp = new Bitmap(getCharacterWidth() * 16, getCharacterHeight() * 16);
                fontCache.Add(newKey, bmp);

                var font = new Font(fontName, (float)nudFontSize.Value);
                var brush = new SolidBrush(Foreground);

                using (Graphics g = Graphics.FromImage(bmp)) {
                    g.Clear(Background);

                    int index;

                    for (var b = 0; b < 16; b++)
                        for (var a = 0; a < 16; a++) {
                            index = b * 16 + a;

                            g.DrawString(
                                index < 32
                                ? "" + top32[index]
                                : index == 0x7f
                                ? "\u2302"
                                : "" + ((char)index), font, brush, new Point(a * getCharacterWidth(), b * getCharacterHeight()));
                        }
                }

                pbPreview.Image = bmp;
            } else pbPreview.Image = fontCache[newKey];
        }

        private void lsbFontList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbFontList.SelectedIndex < 0) return;

            regeneratePreview();
        }

        private void txbSearch_KeyDown(object sender, KeyEventArgs e) {
            lsbFontList.Items.Clear();
            lsbFontList.Items.AddRange(
                fontNames
                    .Select(x => x.ToLower())
                    .Where(x => x.Contains(txbSearch.Text.ToLower())).ToArray());
        }

        private void nudFontSize_ValueChanged(object sender, EventArgs e) {
            regeneratePreview();
        }

        private void nudCharacterWidth_ValueChanged(object sender, EventArgs e) {
            regeneratePreview();
        }

        private void btnForeground_Click(object sender, EventArgs e) {
            colourDialogue.Color = Foreground;
            if (colourDialogue.ShowDialog() == DialogResult.OK) {
                Foreground = colourDialogue.Color;
                regeneratePreview();
            }
        }

        private void btnBackground_Click(object sender, EventArgs e) {
            colourDialogue.Color = Background;
            if (colourDialogue.ShowDialog() == DialogResult.OK) {
                Background = colourDialogue.Color;
                regeneratePreview();
            }
        }

        private void nudCharacterHeight_ValueChanged(object sender, EventArgs e) {
            regeneratePreview();
        }
    }

    // https://stackoverflow.com/questions/46023726/
    class FontCacheKey {
        static int currentID = 0;
        static int getNextAvailableID() {
            return currentID++;
        }

        public readonly int id;
        public string Name;
        public int fontSizeEm, characterWidth, characterHeight;
        // Todo: foreground & background
        public FontCacheKey(string fontName, int fontSizeEm, int characterWidth, int characterHeight) {
            id = getNextAvailableID();
            this.Name = fontName;
            this.fontSizeEm = fontSizeEm;
            this.characterWidth = characterWidth;
            this.characterHeight = characterHeight;
        }

        public override int GetHashCode() {
            return currentID;
        }

        public override bool Equals(object obj) {
            return Equals(obj as FontCacheKey);
        }

        public bool Equals(FontCacheKey other) {
            return other != null &&
                other.Name == Name &&
                other.fontSizeEm == fontSizeEm &&
                other.characterWidth == characterWidth &&
                other.characterHeight == characterHeight;
        }
    }
}
