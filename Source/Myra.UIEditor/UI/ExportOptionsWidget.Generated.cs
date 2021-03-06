/* Generated by Myra UI Editor at 28.10.2018 20:56:41 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.UIEditor.UI
{
	partial class ExportOptionsWidget
	{
		private void BuildUI()
		{
			var textBlock1 = new TextBlock();
			textBlock1.Text = "Class Name:";
			textBlock1.Id = "";
			textBlock1.GridPositionY = 1;

			_textClassName = new TextField();
			_textClassName.Text = "";
			_textClassName.Id = "_textClassName";
			_textClassName.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textClassName.GridPositionX = 1;
			_textClassName.GridPositionY = 1;
			_textClassName.ClipToBounds = true;
			_textClassName.CanFocus = true;

			var textBlock2 = new TextBlock();
			textBlock2.Text = "Output Path:";
			textBlock2.GridPositionY = 2;

			_textOutputPath = new TextField();
			_textOutputPath.Text = "";
			_textOutputPath.Id = "_textOutputPath";
			_textOutputPath.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textOutputPath.GridPositionX = 1;
			_textOutputPath.GridPositionY = 2;
			_textOutputPath.ClipToBounds = true;
			_textOutputPath.CanFocus = true;

			_buttonChangeOutputPath = new Button();
			_buttonChangeOutputPath.Text = "Change...";
			_buttonChangeOutputPath.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_buttonChangeOutputPath.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			_buttonChangeOutputPath.Id = "_buttonChangeOutputPath";
			_buttonChangeOutputPath.GridPositionX = 2;
			_buttonChangeOutputPath.GridPositionY = 2;

			var textBlock3 = new TextBlock();
			textBlock3.Text = "Namespace:";

			_textNamespace = new TextField();
			_textNamespace.Text = "";
			_textNamespace.Id = "_textNamespace";
			_textNamespace.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textNamespace.GridPositionX = 1;
			_textNamespace.ClipToBounds = true;
			_textNamespace.CanFocus = true;

			
			DrawLinesColor = Color.White;
			ColumnSpacing = 8;
			RowSpacing = 8;
			ColumnsProportions.Add(new Grid.Proportion());
			ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			ColumnsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			RowsProportions.Add(new Grid.Proportion());
			Id = "Root";
			WidthHint = 800;
			HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			Widgets.Add(textBlock1);
			Widgets.Add(_textClassName);
			Widgets.Add(textBlock2);
			Widgets.Add(_textOutputPath);
			Widgets.Add(_buttonChangeOutputPath);
			Widgets.Add(textBlock3);
			Widgets.Add(_textNamespace);
		}

		
		public TextField _textClassName;
		public TextField _textOutputPath;
		public Button _buttonChangeOutputPath;
		public TextField _textNamespace;
	}
}