# Project-Autumn 0.1
Online chat with webinterface and desktop application

---UNDER DEVELOPMENT---
Web version is now working with one lobby running.

Desktop version is still VIP but is running with 2 lobbies



--- DATABASE SETUP ---

To set up the database for the chat start off by makeing a MySqlDB named " Chat "

To create the mainlobby use the following query:

``` MYSQL
CREATE TABLE `mainlobby` (
 `Id` int(11) NOT NULL AUTO_INCREMENT,
 `sentfrom` text CHARACTER SET latin1,
 `message` varchar(1024) DEFAULT NULL,
 `currenttime` datetime DEFAULT CURRENT_TIMESTAMP,
 PRIMARY KEY (`Id`)
) ENGINE=InnoDB AUTO_INCREMENT=4878 DEFAULT CHARSET=utf8
```


To create the user database containing username email password etc use the follow query:

``` MYSQL
CREATE TABLE `users` (
 `Id` int(11) NOT NULL AUTO_INCREMENT,
 `username` varchar(128) CHARACTER SET latin1 DEFAULT NULL,
 `password` varchar(128) CHARACTER SET latin1 DEFAULT NULL,
 `email` varchar(128) CHARACTER SET latin1 DEFAULT NULL,
 `mode` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
 `dongermoney` int(11) NOT NULL DEFAULT '10',
 `location` varchar(45) CHARACTER SET latin1 DEFAULT NULL,
 `privileges` int(11) DEFAULT '0',
 `createdate` datetime DEFAULT CURRENT_TIMESTAMP,
 `lastloginip` varchar(45) DEFAULT NULL,
 PRIMARY KEY (`Id`),
 UNIQUE KEY `users_UNIQUE` (`username`),
 UNIQUE KEY `email_UNIQUE` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=73 DEFAULT CHARSET=utf8
```
