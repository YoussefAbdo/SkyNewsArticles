using SkyNewsArticles.Models;
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
    public partial class ArticleBodyPage : ContentPage
    {
        public ArticleBodyPage(Article article)
        {
            InitializeComponent();
            TitleLabel.Text = article.Title;
            BodyLabel.Text = article.Body;

        }
    }
}