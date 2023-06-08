# ShapeLibrary
# Задача на C#

*Напишите на C# библиотеку для поставки внешним клиентам, которая умеет вычислять площадь круга по радиусу и треугольника по трем сторонам. Дополнительно к работоспособности оценим:*

 *- Юнит-тесты*
 
 *- Легкость добавления других фигур*
 
 *- Вычисление площади фигуры без знания типа фигуры*
 
 *- Проверку на то, является ли треугольник прямоугольным"*

# Пример использования библиотеки:
<pre><code class="language-csharp">
static void Main()
{
    List<Shape> shapes = new()
    {
        new Circle(5),
        new Triangle(3, 4, 5)
    };

    foreach (Shape shape in shapes)
    {
        Console.WriteLine(value: $"Area {shape.CalculateArea()}");
        if (shape is Triangle triangle)
        {
            Console.WriteLine($"Is the triangle right-angled? {triangle.IsRightAngled()}");
        }
    }
}
</code></pre>

# Задача на SQL
*В базе данных MS SQL Server есть продукты и категории. Одному продукту может соответствовать много категорий, в одной категории может быть много продуктов. Напишите SQL запрос для выбора всех пар «Имя продукта – Имя категории». Если у продукта нет категорий, то его имя все равно должно выводиться.*

## Решение:
<pre><code class="language-sql">
SELECT ProductName, CategoryName FROM Products P 
LEFT JOIN Categories C ON C.CategoryID = P.CategoryID
</code></pre>
#База данных  для проверки https://www.w3schools.com/sql/trysql.asp?filename=trysql_asc
