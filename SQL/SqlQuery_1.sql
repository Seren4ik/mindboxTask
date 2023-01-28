SELECT P.Name as 'Product', C.Name as 'Category'
FROM Products P
LEFT JOIN Products_To_Categories (NOLOCK) PTC ON PTC.ProductId = P.Id
LEFT JOIN Categories (NOLOCK) C ON PTC.CategoryId = C.Id