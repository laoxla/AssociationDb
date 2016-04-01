namespace Associations.Controllers {

    export class HomeController {
        public message = 'Hello from the home page!';
    }



    export class AboutController {
        public message = 'Hello from the about page!';
    }

    export class MovieListController {

        public movieList;

        constructor(private $http: ng.IHttpService) {
            $http.get("/api/movie")
                .then((response) => {
                    this.movieList = response.data;
                })
                .catch(() => {

                })

        }

    }

}
