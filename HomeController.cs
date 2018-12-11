using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using IMDBApp.Models;
using BusinessLayer.BusinessEntities;

namespace IMDBApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeBusinessLayer objBL = new HomeBusinessLayer();
            List<Movie2018Entity> objEntity = new List<Movie2018Entity>();
            List<Movies2018> objModal = new List<Movies2018>();
            objEntity = objBL.GetMovies2018();
            objModal = Movie2018Mapper(objEntity);
            return View(objModal);

        }

        public ActionResult WishListGrid(string movieCode = null)
        {
            HomeBusinessLayer objBL = new HomeBusinessLayer();
            IList<MovieReviewEntity> objEntity = new List<MovieReviewEntity>();
            IList<MovieReview> objModal = new List<MovieReview>();



            if(movieCode == null)
            {
                objEntity = objBL.GetReviewList();
                objModal = MovieReviewMapper(objEntity);
                return PartialView("WishListGrid", objModal);
            }
            else
            {
                objEntity = objBL.GetReviewList();
                objModal = MovieReviewMapper(objEntity);
                foreach (var tom in objModal.Where(w => w.MovieCode == movieCode))
                {
                    tom.ActionStatus = "Edit";
                }
                return PartialView("WishListGrid", objModal);

            }
            

           

        }

        public ActionResult WishList()
        {
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<Movies2018> Movie2018Mapper(List<Movie2018Entity> entityList)
        {
            List<Movies2018> modalList = new List<Movies2018>();
            for(int i=0;i< entityList.Count;i++)
            {
                Movies2018 objMovie = new Movies2018();
                objMovie.MovieCode = entityList[i].MovieCode;
                objMovie.MovieName = entityList[i].MovieName;
                objMovie.MovieDetails = entityList[i].MovieDetails;
                objMovie.ImageId = entityList[i].ImageId;
                objMovie.IMDBRating = entityList[i].IMDBRating;
                objMovie.ReleaseYear = entityList[i].ReleaseYear;
                objMovie.Runtime = entityList[i].Runtime;
                objMovie.Actor = entityList[i].Actor;
                objMovie.BoxOfficeCollection = entityList[i].BoxOfficeCollection;
                objMovie.Director = entityList[i].Director;
                objMovie.genre = entityList[i].genre;

                modalList.Add(objMovie);

            }
            return modalList;

        }

        public IList<MovieReview> MovieReviewMapper(IList<MovieReviewEntity> entityList)
        {
            IList<MovieReview> modalList = new List<MovieReview>();
            for (int i = 0; i < entityList.Count; i++)
            {
                MovieReview objMovie = new MovieReview();
                objMovie.Dialogue = entityList[i].Dialogue;
                objMovie.Direction = entityList[i].Direction;
                objMovie.Editing = entityList[i].Editing;
                objMovie.genre = entityList[i].genre;
                objMovie.MovieCode = entityList[i].MovieCode;
                objMovie.MovieName = entityList[i].MovieName;
                objMovie.Music = entityList[i].Music;
                objMovie.Performances = entityList[i].Performances;
                objMovie.ReleaseYear = entityList[i].ReleaseYear;
                objMovie.Writing = entityList[i].Writing;
                

                modalList.Add(objMovie);

            }
            return modalList;

        }


    }
}