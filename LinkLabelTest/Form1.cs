using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace LinkLabelTest
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void linkLabel1_LinkClicked( 
      object sender, 
      LinkLabelLinkClickedEventArgs e )
    {
      Process.Start( "http://thebuildingcoder.typepad.com" );
    }
  }
}
