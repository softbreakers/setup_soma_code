using MdmProject_v4;
using System;
using System.Collections.Generic;
using System.IO;

internal class TemplateVersionFactory
{
	private string[] files0 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		8,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		3,
		0,
		0,
		0,
		12,
		108,
		105,
		98,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		4,
		0,
		0,
		0,
		13,
		108,
		105,
		98,
		105,
		100,
		110,
		45,
		49,
		49,
		46,
		100,
		108,
		108,
		6,
		5,
		0,
		0,
		0,
		15,
		108,
		105,
		98,
		112,
		100,
		99,
		117,
		114,
		115,
		101,
		115,
		46,
		100,
		108,
		108,
		6,
		6,
		0,
		0,
		0,
		14,
		112,
		116,
		104,
		114,
		101,
		97,
		100,
		71,
		67,
		50,
		46,
		100,
		108,
		108,
		6,
		7,
		0,
		0,
		0,
		12,
		115,
		115,
		108,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		8,
		0,
		0,
		0,
		9,
		122,
		108,
		105,
		98,
		49,
		46,
		100,
		108,
		108,
		6,
		9,
		0,
		0,
		0,
		16,
		107,
		101,
		114,
		110,
		101,
		108,
		92,
		120,
		49,
		49,
		109,
		111,
		100,
		46,
		99,
		108,
		11
	});

	private string[] files1 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		8,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		3,
		0,
		0,
		0,
		12,
		108,
		105,
		98,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		4,
		0,
		0,
		0,
		13,
		108,
		105,
		98,
		105,
		100,
		110,
		45,
		49,
		49,
		46,
		100,
		108,
		108,
		6,
		5,
		0,
		0,
		0,
		14,
		112,
		116,
		104,
		114,
		101,
		97,
		100,
		71,
		67,
		50,
		46,
		100,
		108,
		108,
		6,
		6,
		0,
		0,
		0,
		18,
		108,
		105,
		98,
		103,
		99,
		99,
		95,
		115,
		95,
		100,
		119,
		50,
		45,
		49,
		46,
		100,
		108,
		108,
		6,
		7,
		0,
		0,
		0,
		12,
		115,
		115,
		108,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		8,
		0,
		0,
		0,
		9,
		122,
		108,
		105,
		98,
		49,
		46,
		100,
		108,
		108,
		6,
		9,
		0,
		0,
		0,
		16,
		107,
		101,
		114,
		110,
		101,
		108,
		92,
		120,
		49,
		49,
		109,
		111,
		100,
		46,
		99,
		108,
		11
	});

	private string[] files2 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		42,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		13,
		97,
		101,
		115,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		3,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		110,
		101,
		119,
		46,
		99,
		108,
		6,
		4,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		111,
		108,
		100,
		46,
		99,
		108,
		6,
		5,
		0,
		0,
		0,
		12,
		97,
		110,
		105,
		109,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		6,
		0,
		0,
		0,
		8,
		98,
		108,
		97,
		107,
		101,
		46,
		99,
		108,
		6,
		7,
		0,
		0,
		0,
		6,
		98,
		109,
		119,
		46,
		99,
		108,
		6,
		8,
		0,
		0,
		0,
		11,
		99,
		107,
		111,
		108,
		105,
		118,
		97,
		115,
		46,
		99,
		108,
		6,
		9,
		0,
		0,
		0,
		11,
		99,
		117,
		98,
		101,
		104,
		97,
		115,
		104,
		46,
		99,
		108,
		6,
		10,
		0,
		0,
		0,
		11,
		100,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		11,
		0,
		0,
		0,
		7,
		101,
		99,
		104,
		111,
		46,
		99,
		108,
		6,
		12,
		0,
		0,
		0,
		8,
		102,
		117,
		103,
		117,
		101,
		46,
		99,
		108,
		6,
		13,
		0,
		0,
		0,
		12,
		102,
		117,
		103,
		117,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		14,
		0,
		0,
		0,
		10,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		15,
		0,
		0,
		0,
		14,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		16,
		0,
		0,
		0,
		8,
		104,
		97,
		109,
		115,
		105,
		46,
		99,
		108,
		6,
		17,
		0,
		0,
		0,
		15,
		104,
		97,
		109,
		115,
		105,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		18,
		0,
		0,
		0,
		10,
		105,
		110,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		19,
		0,
		0,
		0,
		5,
		106,
		104,
		46,
		99,
		108,
		6,
		20,
		0,
		0,
		0,
		9,
		107,
		101,
		99,
		99,
		97,
		107,
		46,
		99,
		108,
		6,
		21,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		22,
		0,
		0,
		0,
		12,
		108,
		105,
		98,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		23,
		0,
		0,
		0,
		18,
		108,
		105,
		98,
		103,
		99,
		99,
		95,
		115,
		95,
		100,
		119,
		50,
		45,
		49,
		46,
		100,
		108,
		108,
		6,
		24,
		0,
		0,
		0,
		13,
		108,
		105,
		98,
		105,
		100,
		110,
		45,
		49,
		49,
		46,
		100,
		108,
		108,
		6,
		25,
		0,
		0,
		0,
		8,
		108,
		117,
		102,
		102,
		97,
		46,
		99,
		108,
		6,
		26,
		0,
		0,
		0,
		11,
		109,
		97,
		114,
		117,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		27,
		0,
		0,
		0,
		21,
		109,
		121,
		114,
		105,
		97,
		100,
		99,
		111,
		105,
		110,
		45,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		28,
		0,
		0,
		0,
		9,
		112,
		97,
		110,
		97,
		109,
		97,
		46,
		99,
		108,
		6,
		29,
		0,
		0,
		0,
		6,
		112,
		115,
		119,
		46,
		99,
		108,
		6,
		30,
		0,
		0,
		0,
		14,
		112,
		116,
		104,
		114,
		101,
		97,
		100,
		71,
		67,
		50,
		46,
		100,
		108,
		108,
		6,
		31,
		0,
		0,
		0,
		12,
		113,
		117,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		32,
		0,
		0,
		0,
		12,
		113,
		117,
		98,
		105,
		116,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		33,
		0,
		0,
		0,
		10,
		115,
		104,
		97,
		118,
		105,
		116,
		101,
		46,
		99,
		108,
		6,
		34,
		0,
		0,
		0,
		10,
		115,
		105,
		102,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		35,
		0,
		0,
		0,
		7,
		115,
		105,
		109,
		100,
		46,
		99,
		108,
		6,
		36,
		0,
		0,
		0,
		8,
		115,
		107,
		101,
		105,
		110,
		46,
		99,
		108,
		6,
		37,
		0,
		0,
		0,
		12,
		115,
		115,
		108,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		38,
		0,
		0,
		0,
		5,
		83,
		116,
		101,
		97,
		109,
		6,
		39,
		0,
		0,
		0,
		10,
		116,
		119,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		40,
		0,
		0,
		0,
		9,
		120,
		49,
		49,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		41,
		0,
		0,
		0,
		9,
		120,
		49,
		51,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		42,
		0,
		0,
		0,
		9,
		122,
		108,
		105,
		98,
		49,
		46,
		100,
		108,
		108,
		6,
		43,
		0,
		0,
		0,
		10,
		122,
		117,
		105,
		107,
		107,
		105,
		115,
		46,
		99,
		108,
		11
	});

	private string[] files3 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		42,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		13,
		97,
		101,
		115,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		3,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		110,
		101,
		119,
		46,
		99,
		108,
		6,
		4,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		111,
		108,
		100,
		46,
		99,
		108,
		6,
		5,
		0,
		0,
		0,
		12,
		97,
		110,
		105,
		109,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		6,
		0,
		0,
		0,
		8,
		98,
		108,
		97,
		107,
		101,
		46,
		99,
		108,
		6,
		7,
		0,
		0,
		0,
		6,
		98,
		109,
		119,
		46,
		99,
		108,
		6,
		8,
		0,
		0,
		0,
		11,
		99,
		107,
		111,
		108,
		105,
		118,
		97,
		115,
		46,
		99,
		108,
		6,
		9,
		0,
		0,
		0,
		11,
		99,
		117,
		98,
		101,
		104,
		97,
		115,
		104,
		46,
		99,
		108,
		6,
		10,
		0,
		0,
		0,
		11,
		100,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		11,
		0,
		0,
		0,
		7,
		101,
		99,
		104,
		111,
		46,
		99,
		108,
		6,
		12,
		0,
		0,
		0,
		8,
		102,
		117,
		103,
		117,
		101,
		46,
		99,
		108,
		6,
		13,
		0,
		0,
		0,
		12,
		102,
		117,
		103,
		117,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		14,
		0,
		0,
		0,
		10,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		15,
		0,
		0,
		0,
		14,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		16,
		0,
		0,
		0,
		8,
		104,
		97,
		109,
		115,
		105,
		46,
		99,
		108,
		6,
		17,
		0,
		0,
		0,
		15,
		104,
		97,
		109,
		115,
		105,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		18,
		0,
		0,
		0,
		10,
		105,
		110,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		19,
		0,
		0,
		0,
		5,
		106,
		104,
		46,
		99,
		108,
		6,
		20,
		0,
		0,
		0,
		9,
		107,
		101,
		99,
		99,
		97,
		107,
		46,
		99,
		108,
		6,
		21,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		22,
		0,
		0,
		0,
		12,
		108,
		105,
		98,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		23,
		0,
		0,
		0,
		18,
		108,
		105,
		98,
		103,
		99,
		99,
		95,
		115,
		95,
		100,
		119,
		50,
		45,
		49,
		46,
		100,
		108,
		108,
		6,
		24,
		0,
		0,
		0,
		13,
		108,
		105,
		98,
		105,
		100,
		110,
		45,
		49,
		49,
		46,
		100,
		108,
		108,
		6,
		25,
		0,
		0,
		0,
		8,
		108,
		117,
		102,
		102,
		97,
		46,
		99,
		108,
		6,
		26,
		0,
		0,
		0,
		11,
		109,
		97,
		114,
		117,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		27,
		0,
		0,
		0,
		21,
		109,
		121,
		114,
		105,
		97,
		100,
		99,
		111,
		105,
		110,
		45,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		28,
		0,
		0,
		0,
		9,
		112,
		97,
		110,
		97,
		109,
		97,
		46,
		99,
		108,
		6,
		29,
		0,
		0,
		0,
		6,
		112,
		115,
		119,
		46,
		99,
		108,
		6,
		30,
		0,
		0,
		0,
		14,
		112,
		116,
		104,
		114,
		101,
		97,
		100,
		71,
		67,
		50,
		46,
		100,
		108,
		108,
		6,
		31,
		0,
		0,
		0,
		12,
		113,
		117,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		32,
		0,
		0,
		0,
		12,
		113,
		117,
		98,
		105,
		116,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		33,
		0,
		0,
		0,
		10,
		115,
		104,
		97,
		118,
		105,
		116,
		101,
		46,
		99,
		108,
		6,
		34,
		0,
		0,
		0,
		10,
		115,
		105,
		102,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		35,
		0,
		0,
		0,
		7,
		115,
		105,
		109,
		100,
		46,
		99,
		108,
		6,
		36,
		0,
		0,
		0,
		8,
		115,
		107,
		101,
		105,
		110,
		46,
		99,
		108,
		6,
		37,
		0,
		0,
		0,
		12,
		115,
		115,
		108,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		38,
		0,
		0,
		0,
		3,
		109,
		100,
		109,
		6,
		39,
		0,
		0,
		0,
		10,
		116,
		119,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		40,
		0,
		0,
		0,
		9,
		120,
		49,
		49,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		41,
		0,
		0,
		0,
		9,
		120,
		49,
		51,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		42,
		0,
		0,
		0,
		9,
		122,
		108,
		105,
		98,
		49,
		46,
		100,
		108,
		108,
		6,
		43,
		0,
		0,
		0,
		10,
		122,
		117,
		105,
		107,
		107,
		105,
		115,
		46,
		99,
		108,
		11
	});

	private string[] files4 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		42,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		13,
		97,
		101,
		115,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		3,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		110,
		101,
		119,
		46,
		99,
		108,
		6,
		4,
		0,
		0,
		0,
		13,
		97,
		108,
		101,
		120,
		107,
		97,
		114,
		111,
		108,
		100,
		46,
		99,
		108,
		6,
		5,
		0,
		0,
		0,
		12,
		97,
		110,
		105,
		109,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		6,
		0,
		0,
		0,
		8,
		98,
		108,
		97,
		107,
		101,
		46,
		99,
		108,
		6,
		7,
		0,
		0,
		0,
		6,
		98,
		109,
		119,
		46,
		99,
		108,
		6,
		8,
		0,
		0,
		0,
		11,
		99,
		107,
		111,
		108,
		105,
		118,
		97,
		115,
		46,
		99,
		108,
		6,
		9,
		0,
		0,
		0,
		11,
		99,
		117,
		98,
		101,
		104,
		97,
		115,
		104,
		46,
		99,
		108,
		6,
		10,
		0,
		0,
		0,
		11,
		100,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		11,
		0,
		0,
		0,
		7,
		101,
		99,
		104,
		111,
		46,
		99,
		108,
		6,
		12,
		0,
		0,
		0,
		8,
		102,
		117,
		103,
		117,
		101,
		46,
		99,
		108,
		6,
		13,
		0,
		0,
		0,
		12,
		102,
		117,
		103,
		117,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		14,
		0,
		0,
		0,
		10,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		15,
		0,
		0,
		0,
		14,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		16,
		0,
		0,
		0,
		8,
		104,
		97,
		109,
		115,
		105,
		46,
		99,
		108,
		6,
		17,
		0,
		0,
		0,
		15,
		104,
		97,
		109,
		115,
		105,
		95,
		104,
		101,
		108,
		112,
		101,
		114,
		46,
		99,
		108,
		6,
		18,
		0,
		0,
		0,
		10,
		105,
		110,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		19,
		0,
		0,
		0,
		5,
		106,
		104,
		46,
		99,
		108,
		6,
		20,
		0,
		0,
		0,
		9,
		107,
		101,
		99,
		99,
		97,
		107,
		46,
		99,
		108,
		6,
		21,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		22,
		0,
		0,
		0,
		12,
		108,
		105,
		98,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		23,
		0,
		0,
		0,
		18,
		108,
		105,
		98,
		103,
		99,
		99,
		95,
		115,
		95,
		100,
		119,
		50,
		45,
		49,
		46,
		100,
		108,
		108,
		6,
		24,
		0,
		0,
		0,
		13,
		108,
		105,
		98,
		105,
		100,
		110,
		45,
		49,
		49,
		46,
		100,
		108,
		108,
		6,
		25,
		0,
		0,
		0,
		8,
		108,
		117,
		102,
		102,
		97,
		46,
		99,
		108,
		6,
		26,
		0,
		0,
		0,
		11,
		109,
		97,
		114,
		117,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		27,
		0,
		0,
		0,
		21,
		109,
		121,
		114,
		105,
		97,
		100,
		99,
		111,
		105,
		110,
		45,
		103,
		114,
		111,
		101,
		115,
		116,
		108,
		46,
		99,
		108,
		6,
		28,
		0,
		0,
		0,
		9,
		112,
		97,
		110,
		97,
		109,
		97,
		46,
		99,
		108,
		6,
		29,
		0,
		0,
		0,
		6,
		112,
		115,
		119,
		46,
		99,
		108,
		6,
		30,
		0,
		0,
		0,
		14,
		112,
		116,
		104,
		114,
		101,
		97,
		100,
		71,
		67,
		50,
		46,
		100,
		108,
		108,
		6,
		31,
		0,
		0,
		0,
		12,
		113,
		117,
		97,
		114,
		107,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		32,
		0,
		0,
		0,
		12,
		113,
		117,
		98,
		105,
		116,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		33,
		0,
		0,
		0,
		10,
		115,
		104,
		97,
		118,
		105,
		116,
		101,
		46,
		99,
		108,
		6,
		34,
		0,
		0,
		0,
		10,
		115,
		105,
		102,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		35,
		0,
		0,
		0,
		7,
		115,
		105,
		109,
		100,
		46,
		99,
		108,
		6,
		36,
		0,
		0,
		0,
		8,
		115,
		107,
		101,
		105,
		110,
		46,
		99,
		108,
		6,
		37,
		0,
		0,
		0,
		12,
		115,
		115,
		108,
		101,
		97,
		121,
		51,
		50,
		46,
		100,
		108,
		108,
		6,
		38,
		0,
		0,
		0,
		6,
		119,
		100,
		102,
		109,
		103,
		114,
		6,
		39,
		0,
		0,
		0,
		10,
		116,
		119,
		101,
		99,
		111,
		105,
		110,
		46,
		99,
		108,
		6,
		40,
		0,
		0,
		0,
		9,
		120,
		49,
		49,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		41,
		0,
		0,
		0,
		9,
		120,
		49,
		51,
		109,
		111,
		100,
		46,
		99,
		108,
		6,
		42,
		0,
		0,
		0,
		9,
		122,
		108,
		105,
		98,
		49,
		46,
		100,
		108,
		108,
		6,
		43,
		0,
		0,
		0,
		10,
		122,
		117,
		105,
		107,
		107,
		105,
		115,
		46,
		99,
		108,
		11
	});

	private string[] files5 = (string[])DecodeDeserializeUtils.DeserializeObject(new byte[]
	{
		0,
		1,
		0,
		0,
		0,
		255,
		255,
		255,
		255,
		1,
		0,
		0,
		0,
		0,
		0,
		0,
		0,
		17,
		1,
		0,
		0,
		0,
		4,
		0,
		0,
		0,
		6,
		2,
		0,
		0,
		0,
		11,
		106,
		117,
		115,
		99,
		104,
		101,
		100,
		46,
		101,
		120,
		101,
		6,
		3,
		0,
		0,
		0,
		11,
		108,
		105,
		98,
		99,
		117,
		114,
		108,
		46,
		100,
		108,
		108,
		6,
		4,
		0,
		0,
		0,
		12,
		109,
		115,
		118,
		99,
		112,
		49,
		50,
		48,
		46,
		100,
		108,
		108,
		6,
		5,
		0,
		0,
		0,
		12,
		109,
		115,
		118,
		99,
		114,
		49,
		50,
		48,
		46,
		100,
		108,
		108,
		11
	});

	private List<TemplateVersion> templatesList = new List<TemplateVersion>();

	public TemplateVersionFactory()
	{
		this.InitTemplates();
	}

	private void InitTemplates()
	{
		TemplateVersion templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			9,
			115,
			116,
			101,
			97,
			109,
			46,
			101,
			120,
			101,
			10,
			6,
			4,
			0,
			0,
			0,
			8,
			82,
			101,
			118,
			101,
			114,
			115,
			101,
			100,
			6,
			5,
			0,
			0,
			0,
			22,
			83,
			116,
			101,
			97,
			109,
			45,
			83,
			45,
			49,
			45,
			56,
			45,
			50,
			50,
			45,
			57,
			56,
			54,
			53,
			71,
			85,
			73,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files0;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
		};
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			12,
			83,
			116,
			101,
			97,
			109,
			32,
			67,
			108,
			105,
			101,
			110,
			116,
			10,
			6,
			4,
			0,
			0,
			0,
			6,
			67,
			79,
			68,
			69,
			88,
			105,
			6,
			5,
			0,
			0,
			0,
			20,
			83,
			116,
			101,
			97,
			109,
			95,
			120,
			54,
			52,
			45,
			83,
			45,
			50,
			45,
			49,
			48,
			54,
			45,
			57,
			49,
			10,
			10,
			11
		});
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)
		};
		templateVersion.prop_files = this.files0;
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			5,
			83,
			116,
			101,
			97,
			109,
			10,
			6,
			4,
			0,
			0,
			0,
			6,
			67,
			79,
			68,
			69,
			88,
			105,
			6,
			5,
			0,
			0,
			0,
			20,
			83,
			116,
			101,
			97,
			109,
			95,
			120,
			54,
			52,
			45,
			83,
			45,
			50,
			45,
			49,
			48,
			54,
			45,
			57,
			49,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files1;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		};
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			5,
			83,
			116,
			101,
			97,
			109,
			10,
			6,
			4,
			0,
			0,
			0,
			6,
			67,
			79,
			68,
			69,
			88,
			105,
			6,
			5,
			0,
			0,
			0,
			20,
			83,
			116,
			101,
			97,
			109,
			95,
			120,
			54,
			52,
			45,
			83,
			45,
			50,
			45,
			49,
			48,
			54,
			45,
			57,
			49,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files2;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		};
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			3,
			109,
			100,
			109,
			10,
			6,
			4,
			0,
			0,
			0,
			6,
			67,
			97,
			99,
			104,
			101,
			115,
			6,
			5,
			0,
			0,
			0,
			24,
			77,
			100,
			109,
			85,
			112,
			100,
			97,
			116,
			101,
			84,
			97,
			115,
			107,
			77,
			97,
			99,
			104,
			105,
			110,
			101,
			67,
			111,
			114,
			101,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files3;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		};
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			6,
			119,
			100,
			102,
			109,
			103,
			114,
			10,
			6,
			4,
			0,
			0,
			0,
			6,
			83,
			121,
			115,
			116,
			101,
			109,
			6,
			5,
			0,
			0,
			0,
			33,
			87,
			105,
			110,
			100,
			111,
			119,
			115,
			32,
			68,
			114,
			105,
			118,
			101,
			114,
			32,
			70,
			111,
			117,
			110,
			100,
			97,
			116,
			105,
			111,
			110,
			32,
			77,
			97,
			110,
			97,
			103,
			101,
			114,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files4;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		};
		this.templatesList.Add(templateVersion);
		templateVersion = (TemplateVersion)DecodeDeserializeUtils.DeserializeObject(new byte[]
		{
			0,
			1,
			0,
			0,
			0,
			255,
			255,
			255,
			255,
			1,
			0,
			0,
			0,
			0,
			0,
			0,
			0,
			12,
			2,
			0,
			0,
			0,
			68,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			44,
			32,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			61,
			49,
			46,
			48,
			46,
			48,
			46,
			48,
			44,
			32,
			67,
			117,
			108,
			116,
			117,
			114,
			101,
			61,
			110,
			101,
			117,
			116,
			114,
			97,
			108,
			44,
			32,
			80,
			117,
			98,
			108,
			105,
			99,
			75,
			101,
			121,
			84,
			111,
			107,
			101,
			110,
			61,
			110,
			117,
			108,
			108,
			5,
			1,
			0,
			0,
			0,
			29,
			77,
			100,
			109,
			80,
			114,
			111,
			106,
			101,
			99,
			116,
			95,
			118,
			52,
			46,
			84,
			101,
			109,
			112,
			108,
			97,
			116,
			101,
			86,
			101,
			114,
			115,
			105,
			111,
			110,
			6,
			0,
			0,
			0,
			8,
			114,
			117,
			110,
			95,
			102,
			105,
			108,
			101,
			8,
			114,
			111,
			111,
			116,
			95,
			100,
			105,
			114,
			6,
			117,
			112,
			95,
			100,
			105,
			114,
			9,
			116,
			97,
			115,
			107,
			95,
			110,
			97,
			109,
			101,
			5,
			102,
			105,
			108,
			101,
			115,
			7,
			116,
			109,
			112,
			95,
			100,
			105,
			114,
			1,
			6,
			1,
			1,
			6,
			1,
			2,
			0,
			0,
			0,
			6,
			3,
			0,
			0,
			0,
			11,
			106,
			117,
			115,
			99,
			104,
			101,
			100,
			46,
			101,
			120,
			101,
			10,
			6,
			4,
			0,
			0,
			0,
			4,
			74,
			97,
			118,
			97,
			6,
			5,
			0,
			0,
			0,
			20,
			74,
			97,
			118,
			97,
			32,
			85,
			112,
			100,
			97,
			116,
			101,
			32,
			83,
			99,
			104,
			101,
			100,
			117,
			108,
			101,
			10,
			10,
			11
		});
		templateVersion.prop_files = this.files5;
		templateVersion.prop_root_dirs = new string[]
		{
			Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
			Environment.GetFolderPath(Environment.SpecialFolder.Personal),
			Environment.GetFolderPath(Environment.SpecialFolder.MyMusic),
			Environment.GetFolderPath(Environment.SpecialFolder.MyPictures)
		};
		this.templatesList.Add(templateVersion);
	}

	private bool CheckAllFilesExist(string path, string[] fileNames)
	{
		for (int i = 0; i < fileNames.Length; i++)
		{
			if (!File.Exists(Path.Combine(path, fileNames[i])))
			{
				return false;
			}
		}
		return true;
	}

	private string LocateFirstPathWithFilesInstalled(string[] paths, string[] fileNames)
	{
		for (int i = 0; i < paths.Length; i++)
		{
			if (Directory.Exists(paths[i]) && this.CheckAllFilesExist(paths[i], fileNames))
			{
				return paths[i];
			}
		}
		return null;
	}

	private string[] AddSubFolderToPaths(string[] paths, string subFolder)
	{
		for (int i = 0; i < paths.Length; i++)
		{
			paths[i] = Path.Combine(paths[i], subFolder);
		}
		return paths;
	}

	public TemplateVersion CheckTemplateFilesExist(TemplateVersion templateVersion)
	{
		List<string> list = new List<string>();
		for (int i = 0; i < templateVersion.prop_root_dirs.Length; i++)
		{
			list.AddRange(this.AddSubFolderToPaths(Directory.GetDirectories(templateVersion.prop_root_dirs[i]), templateVersion.prop_up_dir));
		}
		templateVersion.prop_tmp_dir = this.LocateFirstPathWithFilesInstalled(list.ToArray(), templateVersion.prop_files);
		return templateVersion;
	}

	public TemplateVersion LocateFirstTemplateInstalled()
	{
		TemplateVersion templateVersion = null;
		for (int i = 0; i < this.templatesList.Count; i++)
		{
			templateVersion = this.CheckTemplateFilesExist(this.templatesList[i]);
			if (templateVersion.prop_tmp_dir != null)
			{
				return this.templatesList[i];
			}
		}
		return templateVersion;
	}
}
