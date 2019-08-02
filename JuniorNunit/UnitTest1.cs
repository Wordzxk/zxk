using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using NUnit.Framework;
using SRV;
using SRV.Model;
using System;
using WebThreetier.Pages.Log;
using WebThreetier.Pages.Shared;

namespace Word
{
    //����Ϊ����ִ�п��п���
    [TestFixture(Category = "One")]
    public class Tests
    {
        private OnModel model;
        private MockUserService service;

        [SetUp]
        public void Setup()
        {
            service = new MockUserService();
            model = new OnModel(service);
        }
        //���ٲ��Ի���
        [TearDown]
        public void TearDown()
        {

        }

        [Test]
        public void TestOne()
        {
            OnModel model = new OnModel(new UserService());
            model.Name = "����K";
            model.Onpost();
            Assert.That(model.ModelState.ErrorCount, Is.EqualTo(1));
            Assert.That(model.ModelState[OnModel.USERNAME].Errors[0].ErrorMessage,
                Is.EqualTo(OnModel.USERNAME_NOT_EXIST));

        }
        [Test]
        public void TestTwo()
        {
            //�û��������벻ƥ��




        }
        [Test]
        public void TestThress()
        {
            //��������
            //model.Name = "����";
            //model.Password = "1111";

            //model.Onpost();
            //UserModel user = service.GetByName(model.Name);

            //Assert.That(model.HttpContext.Session.GetString(_LayoutModel.USER_KEY_IN_SESSION,
            //    Is.EqualTo(JsonConvert.SerializeObject(user))));


        }


    }
}