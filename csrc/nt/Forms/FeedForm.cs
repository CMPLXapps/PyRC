using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xIPC.Net;

namespace xIPC.Forms {

public partial class FeedForm : Form {

	public bool CanSend;
	public Antenna NetBridge;

	public FeedForm() {
		InitializeComponent();

		this.CanSend = false;
		this.NetBridge = new P2PAntenna();
	}

	private void sendButton_clicked(object sender, EventArgs e) {
		if ( this.CanSend ) {
			
		} else {}
	}
}



}