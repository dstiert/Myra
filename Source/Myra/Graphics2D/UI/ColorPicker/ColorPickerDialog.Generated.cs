/* Generated by Myra UI Editor at 21.10.2018 17:51:52 */
using Microsoft.Xna.Framework;
using Myra.Graphics2D.UI;

namespace Myra.Graphics2D.UI.ColorPicker
{
	partial class ColorPickerDialog
	{
		private void BuildUI()
		{
			_imageColor = new Image();
			_imageColor.Id = "_imageColor";
			_imageColor.HeightHint = 50;
			_imageColor.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_imageColor.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;

			var horizontalSeparator1 = new HorizontalSeparator();
			horizontalSeparator1.HeightHint = 4;
			horizontalSeparator1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalSeparator1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			horizontalSeparator1.GridPositionY = 1;

			var textBlock1 = new TextBlock();
			textBlock1.Text = "R";
			textBlock1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;

			_spinButtonR = new SpinButton();
			_spinButtonR.Maximum = 255;
			_spinButtonR.Minimum = 0;
			_spinButtonR.Value = 0;
			_spinButtonR.DrawLinesColor = Color.White;
			_spinButtonR.Id = "_spinButtonR";
			_spinButtonR.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonR.GridPositionX = 1;

			_sliderR = new HorizontalSlider();
			_sliderR.Maximum = 255;
			_sliderR.Id = "_sliderR";
			_sliderR.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderR.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderR.GridPositionX = 2;

			var textBlock2 = new TextBlock();
			textBlock2.Text = "G";
			textBlock2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			textBlock2.GridPositionY = 1;

			_spinButtonG = new SpinButton();
			_spinButtonG.Maximum = 255;
			_spinButtonG.Minimum = 0;
			_spinButtonG.Value = 0;
			_spinButtonG.DrawLinesColor = Color.White;
			_spinButtonG.Id = "_spinButtonG";
			_spinButtonG.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonG.GridPositionX = 1;
			_spinButtonG.GridPositionY = 1;

			_sliderG = new HorizontalSlider();
			_sliderG.Maximum = 255;
			_sliderG.Id = "_sliderG";
			_sliderG.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderG.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderG.GridPositionX = 2;
			_sliderG.GridPositionY = 1;

			var textBlock3 = new TextBlock();
			textBlock3.Text = "B";
			textBlock3.GridPositionY = 2;

			_spinButtonB = new SpinButton();
			_spinButtonB.Maximum = 255;
			_spinButtonB.Minimum = 0;
			_spinButtonB.Value = 0;
			_spinButtonB.DrawLinesColor = Color.White;
			_spinButtonB.Id = "_spinButtonB";
			_spinButtonB.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonB.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_spinButtonB.GridPositionX = 1;
			_spinButtonB.GridPositionY = 2;

			_sliderB = new HorizontalSlider();
			_sliderB.Maximum = 255;
			_sliderB.Id = "_sliderB";
			_sliderB.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderB.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderB.GridPositionX = 2;
			_sliderB.GridPositionY = 2;

			var textBlock4 = new TextBlock();
			textBlock4.Text = "A";
			textBlock4.GridPositionY = 3;

			_spinButtonA = new SpinButton();
			_spinButtonA.Maximum = 255;
			_spinButtonA.Minimum = 0;
			_spinButtonA.Value = 0;
			_spinButtonA.DrawLinesColor = Color.White;
			_spinButtonA.Id = "_spinButtonA";
			_spinButtonA.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonA.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_spinButtonA.GridPositionX = 1;
			_spinButtonA.GridPositionY = 3;

			_sliderA = new HorizontalSlider();
			_sliderA.Maximum = 255;
			_sliderA.Id = "_sliderA";
			_sliderA.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderA.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderA.GridPositionX = 2;
			_sliderA.GridPositionY = 3;

			var grid1 = new Grid();
			grid1.DrawLinesColor = Color.White;
			grid1.ColumnSpacing = 8;
			grid1.RowSpacing = 4;
			grid1.ColumnsProportions.Add(new Grid.Proportion());
			grid1.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Pixels,
				Value = 50,
			});
			grid1.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.RowsProportions.Add(new Grid.Proportion());
			grid1.PaddingTop = 4;
			grid1.PaddingBottom = 4;
			grid1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid1.Widgets.Add(textBlock1);
			grid1.Widgets.Add(_spinButtonR);
			grid1.Widgets.Add(_sliderR);
			grid1.Widgets.Add(textBlock2);
			grid1.Widgets.Add(_spinButtonG);
			grid1.Widgets.Add(_sliderG);
			grid1.Widgets.Add(textBlock3);
			grid1.Widgets.Add(_spinButtonB);
			grid1.Widgets.Add(_sliderB);
			grid1.Widgets.Add(textBlock4);
			grid1.Widgets.Add(_spinButtonA);
			grid1.Widgets.Add(_sliderA);

			var verticalSeparator1 = new VerticalSeparator();
			verticalSeparator1.WidthHint = 3;
			verticalSeparator1.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			verticalSeparator1.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			verticalSeparator1.GridPositionX = 1;

			var textBlock5 = new TextBlock();
			textBlock5.Text = "H";

			_spinButtonH = new SpinButton();
			_spinButtonH.Maximum = 360;
			_spinButtonH.Minimum = 0;
			_spinButtonH.Value = 0;
			_spinButtonH.DrawLinesColor = Color.White;
			_spinButtonH.Id = "_spinButtonH";
			_spinButtonH.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonH.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_spinButtonH.GridPositionX = 1;

			_sliderH = new HorizontalSlider();
			_sliderH.Maximum = 360;
			_sliderH.Id = "_sliderH";
			_sliderH.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderH.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderH.GridPositionX = 2;

			var textBlock6 = new TextBlock();
			textBlock6.Text = "S";
			textBlock6.GridPositionY = 1;

			_spinButtonS = new SpinButton();
			_spinButtonS.Maximum = 100;
			_spinButtonS.Minimum = 0;
			_spinButtonS.Value = 0;
			_spinButtonS.DrawLinesColor = Color.White;
			_spinButtonS.Id = "_spinButtonS";
			_spinButtonS.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonS.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_spinButtonS.GridPositionX = 1;
			_spinButtonS.GridPositionY = 1;

			_sliderS = new HorizontalSlider();
			_sliderS.Maximum = 100;
			_sliderS.Id = "_sliderS";
			_sliderS.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderS.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderS.GridPositionX = 2;
			_sliderS.GridPositionY = 1;

			var textBlock7 = new TextBlock();
			textBlock7.Text = "V";
			textBlock7.GridPositionY = 2;

			_spinButtonV = new SpinButton();
			_spinButtonV.Maximum = 100;
			_spinButtonV.Minimum = 0;
			_spinButtonV.Value = 0;
			_spinButtonV.DrawLinesColor = Color.White;
			_spinButtonV.Id = "_spinButtonV";
			_spinButtonV.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_spinButtonV.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_spinButtonV.GridPositionX = 1;
			_spinButtonV.GridPositionY = 2;

			_sliderV = new HorizontalSlider();
			_sliderV.Maximum = 100;
			_sliderV.Id = "_sliderV";
			_sliderV.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_sliderV.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_sliderV.GridPositionX = 2;
			_sliderV.GridPositionY = 2;

			var textBlock8 = new TextBlock();
			textBlock8.Text = "#";
			textBlock8.GridPositionY = 3;

			_textFieldHex = new TextField();
			_textFieldHex.Text = "";
			_textFieldHex.Id = "_textFieldHex";
			_textFieldHex.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_textFieldHex.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_textFieldHex.GridPositionX = 1;
			_textFieldHex.GridPositionY = 3;
			_textFieldHex.GridSpanX = 2;
			_textFieldHex.ClipToBounds = true;
			_textFieldHex.CanFocus = true;

			var grid2 = new Grid();
			grid2.DrawLinesColor = Color.White;
			grid2.ColumnSpacing = 8;
			grid2.RowSpacing = 5;
			grid2.ColumnsProportions.Add(new Grid.Proportion());
			grid2.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Pixels,
				Value = 50,
			});
			grid2.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
			});
			grid2.RowsProportions.Add(new Grid.Proportion());
			grid2.RowsProportions.Add(new Grid.Proportion());
			grid2.RowsProportions.Add(new Grid.Proportion());
			grid2.RowsProportions.Add(new Grid.Proportion());
			grid2.PaddingTop = 4;
			grid2.PaddingBottom = 4;
			grid2.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid2.GridPositionX = 2;
			grid2.Widgets.Add(textBlock5);
			grid2.Widgets.Add(_spinButtonH);
			grid2.Widgets.Add(_sliderH);
			grid2.Widgets.Add(textBlock6);
			grid2.Widgets.Add(_spinButtonS);
			grid2.Widgets.Add(_sliderS);
			grid2.Widgets.Add(textBlock7);
			grid2.Widgets.Add(_spinButtonV);
			grid2.Widgets.Add(_sliderV);
			grid2.Widgets.Add(textBlock8);
			grid2.Widgets.Add(_textFieldHex);

			var grid3 = new Grid();
			grid3.DrawLinesColor = Color.White;
			grid3.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			grid3.ColumnsProportions.Add(new Grid.Proportion());
			grid3.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			grid3.RowsProportions.Add(new Grid.Proportion());
			grid3.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid3.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid3.GridPositionY = 2;
			grid3.Widgets.Add(grid1);
			grid3.Widgets.Add(verticalSeparator1);
			grid3.Widgets.Add(grid2);

			var horizontalSeparator2 = new HorizontalSeparator();
			horizontalSeparator2.HeightHint = 4;
			horizontalSeparator2.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalSeparator2.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			horizontalSeparator2.GridPositionY = 3;

			_gridUserColors = new Grid();
			_gridUserColors.DrawLinesColor = Color.White;
			_gridUserColors.ColumnSpacing = 4;
			_gridUserColors.RowSpacing = 4;
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.ColumnsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Part,
			});
			_gridUserColors.GridSelectionMode = Myra.Graphics2D.UI.GridSelectionMode.Cell;
			_gridUserColors.Id = "_gridUserColors";
			_gridUserColors.HeightHint = 100;
			_gridUserColors.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			_gridUserColors.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;

			_buttonSaveColor = new TextButton();
			_buttonSaveColor.Text = "Save Color";
			_buttonSaveColor.ContentHorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Center;
			_buttonSaveColor.ContentVerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			_buttonSaveColor.Id = "_buttonSaveColor";
			_buttonSaveColor.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Right;
			_buttonSaveColor.GridPositionY = 1;

			var grid4 = new Grid();
			grid4.DrawLinesColor = Color.White;
			grid4.RowSpacing = 4;
			grid4.RowsProportions.Add(new Grid.Proportion());
			grid4.RowsProportions.Add(new Grid.Proportion());
			grid4.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid4.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid4.GridPositionY = 4;
			grid4.Widgets.Add(_gridUserColors);
			grid4.Widgets.Add(_buttonSaveColor);

			var horizontalSeparator3 = new HorizontalSeparator();
			horizontalSeparator3.HeightHint = 4;
			horizontalSeparator3.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			horizontalSeparator3.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Center;
			horizontalSeparator3.GridPositionY = 5;

			var grid5 = new Grid();
			grid5.DrawLinesColor = Color.White;
			grid5.RowSpacing = -1;
			grid5.RowsProportions.Add(new Grid.Proportion
			{
				Type = Myra.Graphics2D.UI.Grid.ProportionType.Fill,
				Value = 100,
			});
			grid5.RowsProportions.Add(new Grid.Proportion());
			grid5.RowsProportions.Add(new Grid.Proportion());
			grid5.RowsProportions.Add(new Grid.Proportion());
			grid5.RowsProportions.Add(new Grid.Proportion());
			grid5.RowsProportions.Add(new Grid.Proportion());
			grid5.HorizontalAlignment = Myra.Graphics2D.UI.HorizontalAlignment.Stretch;
			grid5.VerticalAlignment = Myra.Graphics2D.UI.VerticalAlignment.Stretch;
			grid5.GridPositionY = 1;
			grid5.Widgets.Add(_imageColor);
			grid5.Widgets.Add(horizontalSeparator1);
			grid5.Widgets.Add(grid3);
			grid5.Widgets.Add(horizontalSeparator2);
			grid5.Widgets.Add(grid4);
			grid5.Widgets.Add(horizontalSeparator3);

			
			Title = "Color Picker";
			TitleTextColor = Color.White;
			DrawLinesColor = Color.White;
			XHint = 216;
			YHint = 220;
			WidthHint = 450;
			CanFocus = true;
			Content = grid5;
		}

		
		public Image _imageColor;
		public SpinButton _spinButtonR;
		public HorizontalSlider _sliderR;
		public SpinButton _spinButtonG;
		public HorizontalSlider _sliderG;
		public SpinButton _spinButtonB;
		public HorizontalSlider _sliderB;
		public SpinButton _spinButtonA;
		public HorizontalSlider _sliderA;
		public SpinButton _spinButtonH;
		public HorizontalSlider _sliderH;
		public SpinButton _spinButtonS;
		public HorizontalSlider _sliderS;
		public SpinButton _spinButtonV;
		public HorizontalSlider _sliderV;
		public TextField _textFieldHex;
		public Grid _gridUserColors;
		public TextButton _buttonSaveColor;
	}
}