#region License
// Copyright 2019 Glenn Alon
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

/*
 * Created by SharpDevelop.
 * User: glenn
 * Date: 24/02/2019
 * Time: 11:07 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Base64_Converter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
            var TextToBase64 = System.Text.Encoding.UTF8.GetBytes(textBox1.Text);
            textBox2.Text = System.Convert.ToBase64String(TextToBase64);
		}
		void Button2Click(object sender, EventArgs e)
		{
	        var Base64ToText = System.Convert.FromBase64String(textBox2.Text);
            textBox1.Text =  System.Text.Encoding.UTF8.GetString(Base64ToText);
		}		
	}
}
