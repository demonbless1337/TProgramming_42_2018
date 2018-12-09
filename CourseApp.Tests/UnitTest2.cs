﻿using System;
using CourseApp;
using Xunit;

namespace CourseApp.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void Test6()
        {
            Television tv = new Television();
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            Assert.Equal(1, channel);
            Assert.Equal(1, model);
            Assert.Equal(0, age);
        }
        [Fact]
        public void Test7()
        {
            Television tv = new Television(100);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            Assert.Equal(100, channel);
            Assert.Equal(1, model);
            Assert.Equal(3, age);
        }
        [Fact]
        public void Test8()
        {
            Television tv = new Television(50);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            Assert.Equal(50, channel);
            Assert.Equal(2, model);
            Assert.Equal(7, age);
        }
        [Fact]
        public void Test9()
        {
            Television tv = new Television(7, 1, 6);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            Assert.Equal(7, channel);
            Assert.Equal(1, model);
            Assert.Equal(6, age);
        }
        [Fact]
        public void Test10()
        {
            Television tv = new Television(2, 2, 8);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            string h = "";
            for (int i = 0; i < 3 - channel.ToString().Length; i++) h += "░";
            Assert.Equal($"\nКанал: {channel}, Модель телевизора: {model}, Возвраст телевизора: {age}\n ██████████░▀▀██████████████▀▀░██████████\n ████████████▄░▀▀████████▀▀░▄████████████\n ███████████████▄█▀▀▀▀▀▀█▄███████████████\n ████████████████▄▄▄▄▄▄▄▄████████████████\n ████▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀████\n ███░░▄▄█████████████████████▄░░░▄▄░░░███\n ███░░█▀░Канал {channel}{h}▄▄▄▄█████████░████░░███\n ███░░█░░░░░░░▄████████████████░░▀▀░░░███\n ███░░█░░░░▄███████████████████░░░░░░░███\n ███░░█░░░█████████████████████░░░░░░░███\n ███░░█░░██████████████████████░░░░░░░███\n ███░░█░███████████████████████░▀███░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░█████████████████████████░▄▄▄▄░░███\n ███░░▀███████████████████████▀░░▀▀▀░░███\n ███▄░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░░▄███\n ████████████████████████████████████████", TV);
        }
        [Fact]
        public void Test11()
        {
            Television tv = new Television(2, 1, 8);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            string h = "";
            for (int i = 0; i < 3 - channel.ToString().Length; i++) h += "▒";
            Assert.Equal($"\nКанал: {channel}, Модель телевизора: {model}, Возвраст телевизора: {age}\n ▄██████████████████████████████████████▄\n █▀─▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄▄─▀████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒Канал {channel}{h}▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌█░░██░░█\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌███░░███\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▐▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▒▌████████\n █▄─▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀▀─▄████████\n ▀██████████████████████████████████████▀\n ───▄▄▄████████████████████████████▄▄▄\n ──████████████████████████████████████", TV);
        }
        [Fact]
        public void Test12()
        {
            Television tv = new Television(-1, 20, 20);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test13()
        {
            Television tv = new Television(123, 20, 20);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test14()
        {
            Television tv = new Television(-1, 2, 20);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test15()
        {
            Television tv = new Television(-1, 3, 11);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test16()
        {
            Television tv = new Television(-1, 2, 12);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test17()
        {
            Television tv = new Television(1, 3, 12);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
        [Fact]
        public void Test18()
        {
            Television tv = new Television(123, 2, 20);
            var channel = tv.Channel;
            var model = tv.Model;
            var age = tv.Age;
            string TV = tv.GetInfo();
            Assert.Equal("", TV);
        }
    }
}
