//Класс локаторов
public static class Locators
{
    public static class MainLibraPageLocators
    {
        public static string searchbar = "//input[@id='search-txt']";
        public static string searchbarbutton = "[class='wrap_search__button']";
        public static string popbookspage = "//li/a[text()='Книги']";
    }
    public static class AuthLocators
    {
        public static string authbutton = "//li[@class='auth']";
        public static string authemail = "[wfd-id='id1']";
        public static string authpassw = "[wfd-id='id2']";
        public static string authlogin = "//button[@id='login']";
    }
    public static class BookPageLocators
    {
        public static string bookname = "//h1[@class='title_lvl1']";
        public static string bookautor = "//div[@itemprop='author']/a/span[@itemprop='name']";
        // Кнопка загрузки (Nth1)
        public static string bookdownloadbutton = "//div/a[@class='btn']";
        public static string bookreview = "[class='form-control auto-size comment_div']";
        public static string bookstars5 = "//div[@id='comment-form']//div[@class='one-star star star5']";
        public static string addreview = "//button[@class ='btn leave_comment']";
        public static string allreview = "//ul[@class='comments']/li/div[@class='review_text']";
    }
    public static class SearchPageLocators
    {
        public static string searchresults = "[class = 'item_block item full_block']";
    }
    public static class PopBooksPageLocators
    {
        public static string popbooksall = "//div[@class='item_block item full_block']";
    }
}