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

namespace xIPC.Forms {

public partial class ImgForm : Form {

	public ImgForm(string PathToImg) {
		InitializeComponent();
		if ( !Path.IsPathRooted( PathToImg ) ) { PathToImg = Path.GetFullPath(PathToImg); }
		int StartOfFileName = 0;
		for ( int i = PathToImg.Length - 1; i >= 0; i-- ) {
			if ( PathToImg[i] == '\\' || PathToImg[i] == '/' ) { StartOfFileName = i + 1; break; }
		}
		Text = PathToImg.Substring(StartOfFileName);
		Image SuppliedImage = Image.FromFile(PathToImg);
		Size = new Size( SuppliedImage.Width + 16, SuppliedImage.Height + 39 );
		BackgroundImage = SuppliedImage;
	}
}



}