/*
Navicat MySQL Data Transfer

Source Server         : localhost_3306
Source Server Version : 50509
Source Host           : localhost:3306
Source Database       : student

Target Server Type    : MYSQL
Target Server Version : 50509
File Encoding         : 65001

Date: 2020-01-03 20:39:02
*/

SET FOREIGN_KEY_CHECKS=0;
-- ----------------------------
-- Table structure for `student`
-- ----------------------------
DROP TABLE IF EXISTS `student`;
CREATE TABLE `student` (
  `id` int(255) NOT NULL AUTO_INCREMENT,
  `name` varchar(16) NOT NULL,
  `age` int(32) DEFAULT NULL,
  `sex` int(1) DEFAULT NULL,
  `math` float(32,0) DEFAULT NULL,
  `chinese` float(32,0) DEFAULT NULL,
  `english` float(32,0) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;

-- ----------------------------
-- Records of student
-- ----------------------------
INSERT INTO `student` VALUES ('1', 'jinzi', '1', '1', '50', '20', '30');
INSERT INTO `student` VALUES ('2', 'jinzi', '1', '1', '1', '1', '1');
INSERT INTO `student` VALUES ('3', 'jinzi', '50', '1', '50', '20', '30');
INSERT INTO `student` VALUES ('4', '??', '0', '1', '0', '0', '0');
INSERT INTO `student` VALUES ('5', '??12', '23', '1', '0', '0', '0');
INSERT INTO `student` VALUES ('6', 'ss', '23', '1', '100', '0', '34');
INSERT INTO `student` VALUES ('7', 'woqu', '0', '1', '35', '55', '0');
