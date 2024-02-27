SELECT p.ProductName, c.CategoryName
FROM dbo.Products AS p
LEFT JOIN dbo.ProductsCategories AS pc ON pc.ProductId = p.ProductId
LEFT JOIN dbo.Categories AS c ON c.CategoryId = pc.CategoryId