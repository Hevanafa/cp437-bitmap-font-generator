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

        // Source: Wikipedia (https://en.wikipedia.org/wiki/Code_page_437)
        // Obtain all <span> in the table row
        // [...$0.querySelectorAll("span")].map(span => "\\u" + span.innerText).join("")
        string bottom128 = "\u00C7\u00FC\u00E9\u00E2\u00E4\u00E0\u00E5\u00E7\u00EA\u00EB\u00E8\u00EF\u00EE\u00EC\u00C4\u00C5" + // 8x
            "\u00C9\u00E6\u00C6\u00F4\u00F6\u00F2\u00FB\u00F9\u00FF\u00D6\u00DC\u00A2\u00A3\u00A5\u20A7\u0192" + // 9x
            "\u00E1\u00ED\u00F3\u00FA\u00F1\u00D1\u00AA\u00BA\u00BF\u2310\u00AC\u00BD\u00BC\u00A1\u00AB\u00BB" + // Ax
            "\u2591\u2592\u2593\u2502\u2524\u2561\u2562\u2556\u2555\u2563\u2551\u2557\u255D\u255C\u255B\u2510" + // Bx
            "\u2514\u2534\u252C\u251C\u2500\u253C\u255E\u255F\u255A\u2554\u2569\u2566\u2560\u2550\u256C\u2567" + // Cx
            "\u2568\u2564\u2565\u2559\u2558\u2552\u2553\u256B\u256A\u2518\u250C\u2588\u2584\u258C\u2590\u2580" + // Dx
            "\u03B1\u00DF\u0393\u03C0\u03A3\u03C3\u00B5\u03C4\u03A6\u0398\u03A9\u03B4\u221E\u03C6\u03B5\u2229" +  // Ex
            "\u2261\u00B1\u2265\u2264\u2320\u2321\u00F7\u2248\u00B0\u2219\u00B7\u221A\u207F\u00B2\u25A0\u00A0"; // Fx

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
        bool getTransparentBackground() { return cbTransparentBackground.Checked; }

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
                    if (!getTransparentBackground())
                        g.Clear(Background);

                    int index, a, b;

                    for (b = 0; b < 16; b++)
                        for (a = 0; a < 16; a++) {
                            index = b * 16 + a;

                            g.DrawString(
                                index < 32
                                ? "" + top32[index]
                                : index >= 128
                                ? "" + bottom128[index - 128]
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
                    .Where(x => x.ToLower().Contains(txbSearch.Text.ToLower())).ToArray());
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

        private void cbTransparentBackground_CheckedChanged(object sender, EventArgs e) {
            regeneratePreview();
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
