using Xamarin.Forms;
namespace AsyncButtonApp.Components
{
    public class AsyncButtonView : ContentView
    {
        public static readonly BindableProperty ButtonCornerRadiusProperty = BindableProperty.Create(nameof(ButtonCornerRadius), typeof(int), typeof(AsyncButtonView), 0);
        public static readonly BindableProperty ButtonHasShadowProperty = BindableProperty.Create(nameof(ButtonHasShadow), typeof(bool), typeof(AsyncButtonView), false);
        public static readonly BindableProperty ButtonClippedToBoundsProperty = BindableProperty.Create(nameof(ButtonClippedToBounds), typeof(bool), typeof(AsyncButtonView), false);
        public static readonly BindableProperty ButtonBackgroundColorProperty = BindableProperty.Create(nameof(ButtonBackgroundColor), typeof(Color), typeof(AsyncButtonView), Color.White);
        public static readonly BindableProperty ButtonTextColorProperty = BindableProperty.Create(nameof(ButtonTextColor), typeof(Color), typeof(AsyncButtonView), Color.Black);
        public static readonly BindableProperty ButtonTextProperty = BindableProperty.Create(nameof(ButtonText), typeof(string), typeof(AsyncButtonView), string.Empty);
        public static readonly BindableProperty IsFetchingProperty = BindableProperty.Create(nameof(IsFetching), typeof(bool), typeof(AsyncButtonView), false);
        public static readonly BindableProperty FetchCommandProperty = BindableProperty.Create(nameof(FetchCommand), typeof(Command), typeof(AsyncButtonView), null);

        public int ButtonCornerRadius
        {
            get => (int)GetValue(ButtonCornerRadiusProperty);
            set => SetValue(ButtonCornerRadiusProperty, value);
        }
        public bool ButtonHasShadow
        {
            get => (bool)GetValue(ButtonHasShadowProperty);
            set => SetValue(ButtonHasShadowProperty, value);
        }
        public bool ButtonClippedToBounds
        {
            get => (bool)GetValue(ButtonClippedToBoundsProperty);
            set => SetValue(ButtonClippedToBoundsProperty, value);
        }
        public Color ButtonBackgroundColor
        {
            get => (Color)GetValue(ButtonBackgroundColorProperty);
            set => SetValue(ButtonBackgroundColorProperty, value);
        }
        public Color ButtonTextColor
        {
            get => (Color)GetValue(ButtonTextColorProperty);
            set => SetValue(ButtonTextColorProperty, value);
        }
        public string ButtonText
        {
            get => (string)GetValue(ButtonTextProperty);
            set => SetValue(ButtonTextProperty, value);
        }
        public bool IsFetching
        {
            get => (bool)GetValue(IsFetchingProperty);
            set => SetValue(IsFetchingProperty, value);
        }
        public Command FetchCommand
        {
            get => (Command)GetValue(FetchCommandProperty);
            set => SetValue(FetchCommandProperty, value);
        }
    }
}
