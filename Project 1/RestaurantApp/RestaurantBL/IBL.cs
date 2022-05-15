﻿using RestaurantInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantBL
{
    public interface IBL:IRestaurantSearch
    {
        List<Review> SearchRestaurants(string searchTerm);
        List<Restaurant> GetAllRestaurants();
        List<Review> GetAllReviews();
        List<AverageRating> GetAverageRating();
        List<User> GetUser();
        Restaurant AddRestaurant(Restaurant restaurant);
        Review AddReview(Review review);
        User AddUser(User user);
        List<Restaurant> SearcheRstaurants(string name);
    }
    public interface IRestaurantSearch
    {
        List<Restaurant> SearchAll();
    }
}
