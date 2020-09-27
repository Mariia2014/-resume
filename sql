Так как связь многие ко многим следует создать промежуточную таблицу для храниния 

create table product_category (productId int FOREIGN KEY(product.id), categoryId int OREIGN KEY(category.id))

select p.name, c.name from product as p
left join map on p.id = product_category.product_id 
left join category as c on product_category.category_id = c.id
