﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JewelSuite.Core;

namespace JewelSuite.UnitTests.Core
{
    [TestClass]
    public class VolumeCalculationServiceTest
    {
        [TestMethod]
        public void CalculateOilAndGasVolumeFromTopHorizonTest()
        {
            // Arrangements
            var topHorizonDataInFeet = new int[,]
                    {
                        {9911,9867,9824,9818,9767,9704,9691,9754,9843,10055,10082,10006,9865,9833,9842,9871},
                        {9889,9845,9804,9796,9746,9677,9644,9672,9753,9903,9998,9961,9854,10050,10039,10053},
                        {9845,9807,9792,9784,9732,9641,9580,9590,9639,9658,9757,9808,9824,10186,10421,10399},
                        {9811,9765,9747,9720,9625,9518,9498,9512,9570,9641,9679,9757,9782,10143,10464,10452},
                        {9786,9735,9698,9660,9549,9377,9381,9422,9491,9609,9677,9724,9761,10124,10417,10428},
                        {9776,9712,9656,9591,9472,9293,9320,9370,9437,9508,9588,9652,9734,10129,10409,10388},
                        {9749,9682,9606,9526,9401,9209,9227,9273,9367,9434,9507,9580,9688,10090,10412,10364},
                        {9698,9619,9532,9425,9305,9135,9100,9123,9188,9358,9451,9542,9645,10035,10354,10354},
                        {9714,9618,9525,9415,9211,9059,9047,9078,9115,9279,9409,9509,9604,9996,10316,10336},
                        {9765,9665,9570,9457,9245,8974,8996,9049,9135,9272,9395,9494,9563,9957,10281,10322},
                        {9805,9694,9594,9472,9207,8896,8926,9026,9119,9228,9347,9451,9529,9951,10270,10306},
                        {9982,9734,9616,9489,9217,8826,8860,8964,9106,9189,9290,9407,9499,9916,10268,10291},
                        {10066,9817,9697,9543,9266,8869,8904,8985,9113,9182,9262,9419,9656,9841,10176,10214},
                        {10078,9883,9758,9607,9327,8924,8965,9022,9118,9175,9238,9380,9702,9929,10085,10137},
                        {10118,9933,9778,9638,9373,9000,9062,9088,9140,9149,9194,9319,9653,9868,10017,10069},
                        {10120,9979,9811,9685,9460,9104,9144,9150,9153,9127,9171,9281,9616,9809,9958,10013},
                        {10115,9987,9853,9743,9532,9234,9245,9229,9186,9091,9130,9262,9596,9771,9893,9966},
                        {10172,10067,9949,9863,9624,9323,9283,9237,9185,9103,9126,9274,9627,9786,9898,9972},
                        {10211,10146,10060,9969,9759,9404,9333,9256,9178,9109,9139,9288,9667,9827,9921,9992},
                        {10302,10259,10200,9803,9717,9463,9389,9331,9268,9243,9263,9413,9804,9866,9935,9980},
                        {10313,10264,10235,9916,9654,9560,9493,9435,9396,9390,9410,9530,9927,9997,9972,9993},
                        {10316,10216,10035,10013,9812,9736,9701,9647,9611,9627,9615,9708,10032,10110,10082,10046},
                        {10360,10239,9986,9956,9964,9904,9900,9904,9883,9928,9842,9876,10157,10200,10179,10122},
                        {10383,10278,10040,10014,10029,10057,10099,10134,10179,10285,10168,10095,10271,10295,10255,10202},
                        {10252,10251,10076,10079,10105,10156,10219,10236,10293,10399,10315,10205,10367,10363,10320,10270},
                        {10287,10094,10097,10123,10170,10235,10312,10342,10351,10457,10377,10292,10436,10424,10374,10330}
                    };

            // Actions
            var volumeCalculationService = new VolumeCalculationService();
            var volumeInCubicMeter = volumeCalculationService.CalculateOilAndGasVolumeFromTopHorizon(topHorizonDataInFeet);

            // Assertions
            Assert.AreEqual(volumeInCubicMeter, 2725210467.3667579);
        }
    }
}
