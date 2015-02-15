using System;
using System.Windows.Forms;
using ICSharpCode.Core;
using Frame.GUI.WorkBench;
using ICSharpCode.Core.WinForms;

namespace Frame.GUI.ViewContent
{
    public class ToggleFullscreenCommand : AbstractCommand
    {
        public override void Run()
        {
            WorkbenchSingleton.Workbench.FullScreen = !WorkbenchSingleton.Workbench.FullScreen;
        }
    }
    public class ShowMapCommand : AbstractCommand
    {
        public override void Run()
        {
            WorkbenchSingleton.Workbench.ShowView(new GMapViewWrapper());
        }
    }
	
    public class PanCommand : AbstractCommand
    {
        public override void Run()
        {
            TextViewDisplayBindingWrapper txtwrapper = WorkbenchSingleton.Workbench.ActiveContent as TextViewDisplayBindingWrapper;
            if (txtwrapper == null)
            {
                MessageBox.Show("Null");
            }
            else
            {
                MessageBox.Show(txtwrapper.TitleName);
            }
        }
    }
	public class GoBack : AbstractCommand
	{
		public override void Run()
		{
			((HtmlViewPane)Owner).WebBrowser.GoBack();
		}
	}
	
	public class GoForward : AbstractCommand
	{
		public override void Run()
		{
			((HtmlViewPane)Owner).WebBrowser.GoForward();
		}
	}
	
	public class Stop : AbstractCommand
	{
		public override void Run()
		{
			((HtmlViewPane)Owner).WebBrowser.Stop();
		}
	}
	
	public class Refresh : AbstractCommand
	{
		public override void Run()
		{
			if ((Control.ModifierKeys & Keys.Control) == Keys.Control)
				((HtmlViewPane)Owner).WebBrowser.Refresh(WebBrowserRefreshOption.Completely);
			else
				((HtmlViewPane)Owner).WebBrowser.Refresh();
		}
	}
	
	public class GoHome : AbstractCommand
	{
		public override void Run()
		{
			((HtmlViewPane)Owner).GoHome();
		}
	}
	
	public class GoSearch : AbstractCommand
	{
		public override void Run()
		{
			((HtmlViewPane)Owner).GoSearch();
		}
	}
	
	public class UrlComboBox : AbstractComboBoxCommand
	{
		protected override void OnOwnerChanged(EventArgs e)
		{
			base.OnOwnerChanged(e);
			ToolBarComboBox toolbarItem = (ToolBarComboBox)Owner;
			toolbarItem.ComboBox.Width *= 3;
			((HtmlViewPane)toolbarItem.Caller).SetUrlComboBox(toolbarItem.ComboBox);
		}
	}
	
	public class NewWindow : AbstractCommand
	{
		public override void Run()
		{
			WorkbenchSingleton.Workbench.ShowView(new BrowserPane());
		}
	}
}
