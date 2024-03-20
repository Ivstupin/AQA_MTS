﻿using OpenQA.Selenium;


namespace SeleniumBasic.Pages;

    public class LoginPage : BasePage
    {
        private static string END_POINT = "";

        // Описание элементов
        private static readonly By LoginLogoBy = By.CssSelector("[class='login_logo']"); //лого Swag Labs
        private static readonly By UserNameInputBy = By.Id("user-name"); // поле ввода username
        private static readonly By PswInputBy = By.Id("password");       // поле ввода пароль
        private static readonly By LoginInButtonBy = By.Id("login-button"); // кнопка логин 
        private static readonly By ErrorBy = By.CssSelector("[data-test='error']");// поле для вывода ошибки
        //Users
        string standard_User = "standard_user";
        string locked_Out_User = "locked_out_user";
        string problem_User = "problem_user";
        string performance_Glitch_User = "performance_glitch_user";
        string error_User = "error_user";
        string visual_User = "visual_user";
        //
        string PswForAllUsers = "secret_sauce"; // пароль

        // Инициализация класса
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

    protected override string GetEndpoint()
        {
            return END_POINT;
        }

        public override bool IsPageOpened()
        {
            return LoginInButton.Displayed && UserNameInput.Displayed;
        }

        // Методы
        public IWebElement UserNameInput => WaitsHelper.WaitForExists(UserNameInputBy);
        public IWebElement PswInput => WaitsHelper.WaitForExists(PswInputBy);
        public IWebElement LoginInButton => WaitsHelper.WaitForExists(LoginInButtonBy);
        public IWebElement ErrorLab => WaitsHelper.WaitForExists(ErrorBy);
    
        // Комплексные
        public ProductsPage LoginByStandard_User()
        {
            UserNameInput.SendKeys(standard_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return new ProductsPage(Driver);
        }

        public ProductsPage LoginByProblem_user()
        {
            UserNameInput.SendKeys(problem_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return new ProductsPage(Driver);
        }
    
        public ProductsPage LoginByPerformance_Glitch_User()
        {
            UserNameInput.SendKeys(performance_Glitch_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return new ProductsPage(Driver);
        }

        public ProductsPage LoginByError_User()
        {
            UserNameInput.SendKeys(error_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return new ProductsPage(Driver);
        }
        public ProductsPage LoginByVisual_User()
        {
            UserNameInput.SendKeys(visual_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return new ProductsPage(Driver);
        }
     
        public LoginPage LoginByInvalidUserNameAndPsw()
        {
            UserNameInput.SendKeys("gdf");
            PswInput.SendKeys("fghgf");
            LoginInButton.Click();
            return this;
        }
        public LoginPage LoginByLockedUser()
        {
            UserNameInput.SendKeys(locked_Out_User);
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return this;
        }
        public LoginPage LoginByEmptyUserName()
        {
            UserNameInput.SendKeys("");
            PswInput.SendKeys(PswForAllUsers);
            LoginInButton.Click();
            return this;
        }
        public LoginPage LoginByEmptyPsw()
        {
            UserNameInput.SendKeys("asd");
            PswInput.SendKeys("");
            LoginInButton.Click();
            return this;
        }
    }
