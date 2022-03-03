using RBot;
using RBot.Plugins;
using RBot.Options;

namespace ActionX
{
	public class Loader : RPlugin
	{
		public override string Name => "ActionX";
		public override string Author => "SharpTheNightmare";
		public override string Description => "Does Something...";

		private ToolStripItem? menuitem;

		public override List<IOption> Options => new();

		public override void Load()
		{
			Bot.Log("ActionX Loaded.");
			menuitem = Forms.Main.Plugins.DropDownItems.Add(Name);
			menuitem.Click += MenuStripItem_Click;
		}

		public override void Unload()
		{
			Bot.Log("ActionX Unloaded.");
			menuitem.Click -= MenuStripItem_Click;
			Forms.Main.MainMenu.Items.Remove(menuitem);
		}

		private void MenuStripItem_Click(object sender, EventArgs e)
		{
			if (ActionX.Instance.Visible)
			{
				ActionX.Instance.Hide();
			}
			else
			{
				ActionX.Instance.Show();
				ActionX.Instance.BringToFront();
			}
		}
	}
}