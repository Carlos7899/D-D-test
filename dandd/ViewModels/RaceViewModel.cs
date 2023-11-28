using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dandd.ViewModels
{
  
     /*   internal partial class RaceViewModel : ObservableObject, IDisposable
        {
            private readonly PostService _postService;

            [ObservableProperty]
            public int _UserId;
            [ObservableProperty]
            public int _Id;
            [ObservableProperty]
            public string _Title;
            [ObservableProperty]
            public string _Body;
            //Uma coleção de Post
            [ObservableProperty]
            public ObservableCollection<Post> _posts;


            public PostViewModel()
            {
                Posts = new ObservableCollection<Post>();
                _postService = new PostService();

            }

            //Consumir a API Rest -> Criação dos Commands

            public ICommand GetPostsCommand => new Command(async () => await LoadPostsAsync());

            private async Task LoadPostsAsync()
            {
                try
                {
                    Posts = await _postService.GetAllPostsAsync();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Exceção do service");
                }
            }

            public void Dispose()
            {
                throw new NotImplementedException();
            }*/
        }
    