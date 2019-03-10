using SkyNewsArticles.Models;
using SkyNewsArticles.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SkyNewsArticles
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticlesPage : ContentPage
    {
        ArticlesViewModel articlesViewMode;

        public ArticlesPage()
        {
            InitializeComponent();
            articlesViewMode = new ArticlesViewModel();
            BindingContext = articlesViewMode;
        }
        private async void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            //DependencyService.Get<ArticlesViewModel>().CurrentFlag = (Flag)e.Item;
            await Navigation.PushAsync(new ArticleBodyPage((Article)e.Item));
        }
    }
}