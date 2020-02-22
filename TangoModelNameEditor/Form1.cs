using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TangoModelNameEditor {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        string file_path;

        private void open_button_Click(object sender, EventArgs e) {

            using(OpenFileDialog d = new OpenFileDialog()) {

                d.Filter = "Model Files (model*.bin)|model*.bin";

                if(d.ShowDialog() == DialogResult.OK) {

                    file_path = d.FileName;

                    file_label.Text = file_path;

                    byte[] file_bytes = System.IO.File.ReadAllBytes(file_path);

                    StringBuilder sb = new StringBuilder();

                    for(int i=0;i<10;i++) {

                        Console.WriteLine("name " + (sbyte)file_bytes[8 + i] + " " + zchar2char((sbyte)file_bytes[8 + i]));

                        sb.Append(zchar2char((sbyte)file_bytes[8 + i]));

                    }
                    
                    name_textbox.Text = sb.ToString().Trim();

                }

            }

            

        }

        char zchar2char(sbyte idx) {
            if(idx == 0) return ' ';
            if(idx < 0) {
                if(idx > -27) return (char)('a' - idx - 1);
                idx = (sbyte)(idx * -1);
            }
            if(idx < 27) return (char)('A' + idx - 1);
            if(idx < 37) return (char)('0' + idx - 27);
            if(idx == 37) return '_';
            if(idx == 38) return '-';
            if(idx == 39) return '.';
            if(idx == 40) return ',';
            return ' ';
        }

        byte char2zchar(char c) {
            if(c == '_') return 37;
            if(c >= 'a') return (byte)('a' - c - 1);
            if(c >= 'A') return (byte)(c - 'A' + 1);
            if(c >= '0') return (byte)(c - '0' + 27);
            if(c == '-') return 38;
            if(c == '.') return 39;
            if(c == ',') return 40;
            return 0;
        }
        
        private void save_name_button_Click(object sender, EventArgs e) {

            using(Stream stream = File.Open(file_path, FileMode.Open)) {

                byte[] data = new byte[10];
                
                while(name_textbox.Text.Length < 10) name_textbox.Text += ' ';

                for(int i=0;i<10;i++) {

                    data[i] = char2zchar(name_textbox.Text[i]);

                    Console.WriteLine("byte " + (sbyte)data[i] + " " + zchar2char((sbyte)data[i]) + " " + name_textbox.Text[i]);

                }

                stream.Position = 8;
                stream.Write(data, 0, 10);

                stream.Close();

                name_textbox.Text = name_textbox.Text.Trim();

            }
            
        }

    }
}
