SELECT Product.ProductName, Category.CatagoryName FROM Product
LEFT JOIN ProductCategory ON Product.ProductId = ProductCategory.ProductId
LEFT JOIN Category ON Category.CategoryId = ProductCategory.CategoryId