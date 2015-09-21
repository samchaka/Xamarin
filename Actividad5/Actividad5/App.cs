using System;
using Xamarin.Forms;

namespace Actividad5
{
	public class App
	{
		public static Page GetMainPage ()
		{	
			ContentPage contentPage = new ContentPage();

			//Padding agrega un margen al contenido
			//Device.OnPlatform permite modificar este margen dependiendo de la plataforma IOS, Android y Windows Phone
			//Para saber más sobe Device.OnPlatform revisa 
			contentPage.Padding = new Thickness (5, Device.OnPlatform (20, 5, 5), 5, 5);

			//Stacklayout permite apilar los controles verticalmente
			StackLayout stackLayout = new StackLayout
			{
				Children =
				{
					new Label
					{
						Text = "Blue",
						TextColor = Color.Blue
					},
					new Label
					{
						Text = "Silver",
						TextColor = Color.Silver
					},
					new Label
					{
						Text = "Black",
						TextColor = Color.Black
					},
					new Label
					{
						Text = "Yellow",
						TextColor = Color.Yellow
					},
					new Label
					{
						Text = "Green",
						TextColor = Color.Green
					},
					new Label
					{
						Text = "Red",
						TextColor = Color.Red
					}
				}
			};

			contentPage.Content = stackLayout;
			return contentPage;
		}
	}
}

