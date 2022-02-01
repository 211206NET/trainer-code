SELECT COUNT(Rating) as 'Number of Reviews', RestaurantId 
From Review 
GROUP BY RestaurantId;
-- ^ Query counts number of reviews belonging to each restaurant

SELECT COUNT(Rating) as 'Number of Reviews', Rating 
From Review 
GROUP BY Rating
HAVING Count(Rating) >= 1
ORDER BY Rating DESC;
-- ^ Query counts number of reviews by rating

SELECT AVG(Rating) as 'Avg Rating', RestaurantId
FROM Review
GROUP BY RestaurantId
HAVING AVG(Rating) > 0
ORDER BY AVG(Rating) DESC;

SELECT Restaurant.Id as 'Restaurant Id', Name, Rating, Note FROM Restaurant JOIN Review ON Restaurant.Id = Review.RestaurantId;

--Psuedo Code on getting the store name, all the product it carries, and how many of them it has
SELECT Store.Name, Product.Name, Inventory.Quantity 
FROM Store Join Inventory ON Store.Id = Inventory.StoreId 
JOIN Product ON Inventory.ProductId = Product.Id 
WHERE Store.Name = "Salt and Straw";

SELECT Name From Store
UNION
SELECT Name From Product;
--This Query gets me all the names of Stores and Products

SELECT * FROM Review 
WHERE RestaurantId = (SELECT Id FROM Restaurant WHERE Name = 'Salt and Straw');

SELECT * FROM (SELECT * FROM Review 
WHERE RestaurantId = 
(SELECT Id FROM Restaurant WHERE Name = 'Salt and Straw')) AS SaltandStraw 
WHERE Rating > 3
ORDER BY Id DESC;