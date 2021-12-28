using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad.Classes
{
    public static class FormatText
    {
        public static RichTextBox FormataTexto(string fontName, float fontSize, FontStyle style, string choice, RichTextBox richTextBox)
        {

            //RichTextBox richTextBox = new RichTextBox();
            using (RichTextBox tmpRTB = new RichTextBox())
            {

                tmpRTB.SelectAll();
                tmpRTB.SelectedRtf = richTextBox.SelectedRtf;
                for (int i = 0; i < tmpRTB.TextLength; ++i)
                {

                    tmpRTB.Select(i, 1);
                    if (String.Equals(choice, "fontName")) // No caso de trocar o nome da fonte
                    {
                        tmpRTB.SelectionFont = new Font(fontName, tmpRTB.SelectionFont.Size, tmpRTB.SelectionFont.Style);
                    }
                    else if (String.Equals(choice, "fontSize")) // No caso de trocar o tamanho da fonte
                    {
                        tmpRTB.SelectionFont = new Font(tmpRTB.SelectionFont.Name, fontSize, tmpRTB.SelectionFont.Style);
                    }
                    else if (String.Equals(choice, "fontStyleBold")) // No caso de clicar na opção de negrito
                    {

                        if (tmpRTB.SelectionFont.Bold)
                        {
                            RemoveFontStyle(FontStyle.Bold, tmpRTB);
                        } 
                        else
                        {
                            tmpRTB.SelectionFont = new Font(tmpRTB.SelectionFont.Name, tmpRTB.SelectionFont.Size, style | tmpRTB.SelectionFont.Style | tmpRTB.SelectionFont.Style);
                        }
                    } else if (String.Equals(choice, "fontStyleUnderline")) // No caso de clicar na opção de sublinhado
                    {
                        if (tmpRTB.SelectionFont.Underline)
                        {
                            RemoveFontStyle(FontStyle.Underline, tmpRTB);
                        }
                        else
                        {
                            tmpRTB.SelectionFont = new Font(tmpRTB.SelectionFont.Name, tmpRTB.SelectionFont.Size, style | tmpRTB.SelectionFont.Style | tmpRTB.SelectionFont.Style);
                        }
                    } else if (String.Equals(choice, "fontStyleItalic")) // No caso de clicar na opção de Itálico
                    {
                        if (tmpRTB.SelectionFont.Italic)
                        {
                            RemoveFontStyle(FontStyle.Italic, tmpRTB);
                        }
                        else
                        {
                            tmpRTB.SelectionFont = new Font(tmpRTB.SelectionFont.Name, tmpRTB.SelectionFont.Size, style | tmpRTB.SelectionFont.Style | tmpRTB.SelectionFont.Style);
                        }
                    }
                    else if (String.Equals(choice, "reset")) // No caso de apertar na opção de Resetar
                    {
                        //tmpRTB.SelectionFont = new Font("Arial", 10);
                        tmpRTB.ClearAllFormatting(new Font("Arial", 12f));
                    }

                }
                tmpRTB.SelectAll();
                richTextBox.SelectedRtf = tmpRTB.SelectedRtf;
                return richTextBox;
            }
        }

        public static void RemoveFontStyle(FontStyle style, RichTextBox richTextBox)
        {
            System.Drawing.Font currentFont;
            FontStyle fs;
            currentFont = richTextBox.SelectionFont;
            fs = currentFont.Style;
            //remove style
            fs = fs & ~style;
            richTextBox.SelectionFont = new Font(currentFont.FontFamily, currentFont.Size, fs);

        }
    }
}
