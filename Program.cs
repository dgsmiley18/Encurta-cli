using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
public class Program
{
    public static void Main(string[] args)
    {
        var chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("headless");

        WebDriver driver = new ChromeDriver(chromeOptions);

        var url = "https://www.encurtador.com.br/";
        driver.Navigate().GoToUrl(url);

        var caixa = driver.FindElement(By.XPath("/html/body/main/section[1]/form/div/input"));
        var botao = driver.FindElement(By.XPath("/html/body/main/section[1]/form/div/div/input"));

        Console.Clear();
        Console.Write("Digite a url: ");
        var linkao = Console.ReadLine();

        Console.Clear();
        caixa.SendKeys(linkao);
        botao.Click();

        var resultado = driver.FindElement(By.Id("shortenurl"));
        Console.Clear();
        Console.WriteLine(resultado.GetAttribute("value"));
    }
}