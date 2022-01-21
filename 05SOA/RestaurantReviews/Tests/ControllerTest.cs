// using Xunit;
// using Moq;
// using WebAPI.Controllers;
// using BL;
// using Models;
// using System.Collections.Generic;
// using Microsoft.Extensions.Caching.Memory;


// namespace Tests;

// public class ControllerTest
// {
//     [Fact]
//     public void ReviewControllerGetShouldGetAllReviewsByRestaurantId()
//     {
//         //Arrange, Act, Assert pattern
//         //Arrange step, we need to set up our mocks, so when BL.GetReviewsByRestoId
//         //Gets called, we instead return a stubbed data
//         var mockBL = new Mock<IBL>();
//         int i = 1;
//         mockBL.Setup(x => x.GetReviewsByRestaurantId(i)).Returns(
//                 new List<Review>
//                 {
//                     new Review
//                     { 
//                         Id = 1,
//                         Rating = 5,
//                         Note = "Review One"
//                     },
//                     new Review
//                     {
//                         Id = 2,
//                         Rating = 3,
//                         Note = "Review Two"
//                     }
//                 }
//             );
//         var reviewCtrllr = new ReviewController(mockBL.Object);

//         //Act
//         var result = reviewCtrllr.Get(i);

//         //Assert
//         Assert.NotNull(result);
//         Assert.IsType<List<Review>>(result);
//         Assert.Equal(2, result.Count);
//     }
    
//     [Fact]
//     public void RestaurantControllerListShouldReturnListOfRestaurants()
//     {
//         //Arrange
//         var mockBL = new Mock<IBL>();
//         Restaurant testOne = new Restaurant
//         {
//             Id = 1,
//             Name = "Test One",
//             City = "City One",
//             State = "State One"
//         };
//         Restaurant testTwo = new Restaurant
//         {
//             Id = 2,
//             Name = "Test Two",
//             City = "City Two",
//             State = "State Two"
//         };
//         mockBL.Setup(x => x.GetAllRestaurants()).Returns(
//                 new List<Restaurant>
//                 {
//                     testOne,
//                     testTwo
//                 }
//             );

//         IMemoryCache cache = new MemoryCache(new MemoryCacheOptions());
//         var restoCntrllr = new RestaurantController(mockBL.Object, cache);

//         //Act
//         var result = restoCntrllr.Get();

//         //Assert
//         Assert.IsType<List<Restaurant>>(result);
//         Assert.Equal(2, result.Count);
//         Assert.Contains(testOne, result);
//     }
// }