﻿namespace MathExtension.Tests
{
    public static class InputTestData
    {
        public static LineSegment[] LineSegments { get; } =
        {
            #region [ Passed through the origin lines ]
            // On X-axis line
            new LineSegment(0, 0, 1, 0),
            new LineSegment(-1000000, 0, 1000000, 0),

            // On Y-axis line
            new LineSegment(0, 0, 0, 1),
            new LineSegment(0, -1000000, 0, 1000000),

            // Passed through the origin line, at between 0 and -1 degrees to the axis X
            new LineSegment(0, 0, 1000000, -1),
            new LineSegment(-1000000, 1, 1000000, -1),

            // Passed through the origin line, at -11 degrees to the axis X
            new LineSegment(0, 0, 5, -1),
            new LineSegment(-5000000, 1000000, 5000000, -1000000),

            // Passed through the origin line, at -37 degrees to the axis X
            new LineSegment(0, 0, 4, -3),
            new LineSegment(-4000000, 3000000, 4000000, -3000000),

            // Passed through the origin line, at -45 degrees to the axis X
            new LineSegment(0, 0, -1, 1),
            new LineSegment(1000000, -1000000, -1000000, 1000000),
            #endregion

            #region [ Axis-parallel lines ]
            // X-axis-parallel line, above X-axis
            new LineSegment(0, 1, 1, 1),
            new LineSegment(-1000000, 1, 1000000, 1),

            // X-axis-parallel line, below X-axis
            new LineSegment(0, -1, 1, -1),
            new LineSegment(-1000000, -1, 1000000, -1),

            // Y-axis-parallel line, right-hand from Y-axis
            new LineSegment(1, 0, 1, 1),
            new LineSegment(1, -1000000, 1, 1000000),

            // Y-axis-parallel line, left-hand from Y-axis
            new LineSegment(-1, 0, -1, 1),
            new LineSegment(-1, -1000000, -1, 1000000),
            #endregion

            #region [ Not passed through the origin lines, second quarter ]
            // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
            new LineSegment(-1, 1, 999999, 2),
            new LineSegment(-1000001, 0, 999999, 2),

            // Not passed through the origin line, at 11 degrees to the axis X, second quarter
            new LineSegment(-1, 1, 4, 2),
            new LineSegment(-5000001, -999999, 4999999, 1000001),

            // Not passed through the origin line, at 37 degrees to the axis X, second quarter
            new LineSegment(-1, 1, 3, 4),
            new LineSegment(-4000001, -2999999, 3999999, 3000001),

            // Not passed through the origin line, at 45 degrees to the axis X, second quarter
            new LineSegment(-1, 1, 0, 2),
            new LineSegment(-1000001, -999999, 999999, 1000001),
            #endregion
        };

        public static Vector[] Vectors { get; }

        public static Vector[] ReversedVectors { get; }

        public static Vector[] SinglePoints { get; } =
        {
            new Vector(0, 0),

            new Vector(1, 0),
            new Vector(-1, 1),
            new Vector(-1, -1),

            new Vector(100, 0),
            new Vector(100, -1),
            new Vector(100, -2),
            new Vector(100, -3),
        };

        public static LengthAndAngle[] VectorLengthsAndAngles { get; } =
        {
            new LengthAndAngle(-1, 0),
            new LengthAndAngle(1, 0),
            new LengthAndAngle(1, -1),
            new LengthAndAngle(1, 45),
            new LengthAndAngle(1, -30),
            new LengthAndAngle(1, 90),
            new LengthAndAngle(1, 175),
            new LengthAndAngle(1, -175),
            new LengthAndAngle(1, 180),
            new LengthAndAngle(1, 360),
        };

        public static double[] DoubleNumbers { get; } =
        {
            0, 1, -99.09, 0.1, -0.00000001
        };

        public static int[] IntegerNumbers { get; } =
        {
            0, 1, -1, 100000, -505
        };

        public static Vector?[] Result_ByAngleVector { get; } =
        {
            null,
            new Vector(1, 0),
            new Vector(0.9998476951564, -0.01745240643728),
            new Vector(0.7071067811865, 0.7071067811865),
            new Vector(0.8660254037844, -0.5),
            new Vector(0, 1),
            new Vector(-0.9961946980917, 0.08715574274766),
            new Vector(-0.9961946980917, -0.08715574274766),
            new Vector(-1, 0),
            new Vector(1, 0),
        };

        public static LineABCCoefficients[] Result_ABCCoefficients { get; } =
        {
            #region [ Passed through the origin lines ]
            // On X-axis line
            new LineABCCoefficients(0, -1, 0),
            new LineABCCoefficients(0, -2000000, 0),

            // On Y-axis line
            new LineABCCoefficients(1, 0, 0),
            new LineABCCoefficients(2000000, 0, 0),

            // Passed through the origin line, at between 0 and -1 degrees to the axis X
            new LineABCCoefficients(-1, -1000000, 0),
            new LineABCCoefficients(-2, -2000000, 0),

            // Passed through the origin line, at -11 degrees to the axis X
            new LineABCCoefficients(-1, -5, 0),
            new LineABCCoefficients(-2000000, -10000000, 0),

            // Passed through the origin line, at -37 degrees to the axis X
            new LineABCCoefficients(-3, -4, 0),
            new LineABCCoefficients(-6000000, -8000000, 0),

            // Passed through the origin line, at -45 degrees to the axis X
            new LineABCCoefficients(1, 1, 0),
            new LineABCCoefficients(2000000, 2000000, 0),
            #endregion

            #region [ Axis-parallel lines ]
            // X-axis-parallel line, above X-axis
            new LineABCCoefficients(0, -1, 1),
            new LineABCCoefficients(0, -2000000, 2000000),

            // X-axis-parallel line, below X-axis
            new LineABCCoefficients(0, -1, -1),
            new LineABCCoefficients(0, -2000000, -2000000),

            // Y-axis-parallel line, right-hand from Y-axis
            new LineABCCoefficients(1, 0, -1),
            new LineABCCoefficients(2000000, 0, -2000000),

            // Y-axis-parallel line, left-hand from Y-axis
            new LineABCCoefficients(1, 0, 1),
            new LineABCCoefficients(2000000, 0, 2000000),
            #endregion

            #region [ Not passed through the origin lines, second quarter ]
            // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
            new LineABCCoefficients(1, -1000000, 1000001),
            new LineABCCoefficients(2, -2000000, 2000002),

            // Not passed through the origin line, at 11 degrees to the axis X, second quarter
            new LineABCCoefficients(1, -5, 6),
            new LineABCCoefficients(2000000, -10000000, 12000000),

            // Not passed through the origin line, at 37 degrees to the axis X, second quarter
            new LineABCCoefficients(3, -4, 7),
            new LineABCCoefficients(6000000, -8000000, 14000000),

            // Not passed through the origin line, at 45 degrees to the axis X, second quarter
            new LineABCCoefficients(1, -1, 2),
            new LineABCCoefficients(2000000, -2000000, 4000000),
            #endregion
        };

        public static double[] Result_VectorAngles { get; private set; } =
        {
            #region [ Passed through the origin lines ]
            // On X-axis line
            0, 0,
            // On Y-axis line
            90, 90,
            // Passed through the origin line, at between 0 and -1 degrees to the axis X
            359.999942702, 359.999942702,
            // Passed through the origin line, at -11 degrees to the axis X
            348.690067526, 348.690067526,
            // Passed through the origin line, at -37 degrees to the axis X
            323.130102354, 323.130102354,
            // Passed through the origin line, at -45 degrees to the axis X
            135, 135,
            #endregion

            #region [ Axis-parallel lines ]
            // X-axis-parallel line, above X-axis
            0, 0,
            // X-axis-parallel line, below X-axis
            0, 0,
            // Y-axis-parallel line, right-hand from Y-axis
            90, 90,
            // Y-axis-parallel line, left-hand from Y-axis
            90, 90,
            #endregion

            #region [ Not passed through the origin lines, second quarter ]
            // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
            5.7298E-5, 5.7298E-5,
            // Not passed through the origin line, at 11 degrees to the axis X, second quarter
            11.309932474, 11.309932474,
            // Not passed through the origin line, at 37 degrees to the axis X, second quarter
            36.869897646, 36.869897646,
            // Not passed through the origin line, at 45 degrees to the axis X, second quarter
            45, 45,
            #endregion
        };

        public static double[] Result_ReversedVectorAngles { get; private set; } =
        {
            #region [ Passed through the origin lines ]
            // On X-axis line
            180, 180,
            // On Y-axis line
            270, 270,
            // Passed through the origin line, at between 0 and -1 degrees to the axis X
            179.999942702, 179.999942702,
            // Passed through the origin line, at -11 degrees to the axis X
            168.690067526, 168.690067526,
            // Passed through the origin line, at -37 degrees to the axis X
            143.130102354, 143.130102354,
            // Passed through the origin line, at -45 degrees to the axis X
            315, 315,
            #endregion

            #region [ Axis-parallel lines ]
            // X-axis-parallel line, above X-axis
            180, 180,
            // X-axis-parallel line, below X-axis
            180, 180,
            // Y-axis-parallel line, right-hand from Y-axis
            270, 270,
            // Y-axis-parallel line, left-hand from Y-axis
            270, 270,
            #endregion

            #region [ Not passed through the origin lines, second quarter ]
            // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
            180.000057298, 180.000057298,
            // Not passed through the origin line, at 11 degrees to the axis X, second quarter
            191.309932474, 191.309932474,
            // Not passed through the origin line, at 37 degrees to the axis X, second quarter
            216.869897646, 216.869897646,
            // Not passed through the origin line, at 45 degrees to the axis X, second quarter
            225, 225,
            #endregion
        };

        public static int[][] Result_RelativeToLinePointLocations { get; private set; } =
        {
            // Point (0, 0)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                0, 0,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -11 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -37 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -45 degrees to the axis X
                0, 0,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                -1, -1,
                // Y-axis-parallel line, right-hand from Y-axis
                -1, -1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (1, 0)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                1, 1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                -1, -1,
                // Y-axis-parallel line, right-hand from Y-axis
                0, 0,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (-1, 1)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                -1, -1,
                // On Y-axis line
                -1, -1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                0, 0,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                0, 0,
                // X-axis-parallel line, below X-axis
                -1, -1,
                // Y-axis-parallel line, right-hand from Y-axis
                -1, -1,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                0, 0,
                #endregion
            },
            // Point (-1, -1)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                -1, -1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -11 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -37 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -45 degrees to the axis X
                -1, -1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                -1, -1,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (100, 0)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                1, 1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                -1, -1,
                // Y-axis-parallel line, right-hand from Y-axis
                1, 1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (100, -1)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                1, 1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                1, 1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (100, -2)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                1, 1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                1, 1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
            // Point (100, -3)
            new int[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1, 1,
                // Passed through the origin line, at -11 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -37 degrees to the axis X
                -1, -1,
                // Passed through the origin line, at -45 degrees to the axis X
                1, 1,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                1, 1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1, 1,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1, 1,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1, 1,
                #endregion
            },
        };

        public static double[][] Result_BetweenPointAndLineDistances { get; } =
        {
            // Point (0, 0)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                0, 0,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -11 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -37 degrees to the axis X
                0, 0,
                // Passed through the origin line, at -45 degrees to the axis X
                0, 0,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                1, 1,
                // Y-axis-parallel line, left-hand from Y-axis
                1, 1,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                1.0000009999995, 1.0000009999995,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1.1766968108291043, 1.1766968108291043,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1.4, 1.4,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1.4142135623730951, 1.4142135623730951,
                #endregion
            },
            // Point (1, 0)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                9.999999999995E-7, 9.999999999995E-7,
                // Passed through the origin line, at -11 degrees to the axis X
                0.19611613513818404, 0.19611613513818404,
                // Passed through the origin line, at -37 degrees to the axis X
                0.6, 0.6,
                // Passed through the origin line, at -45 degrees to the axis X
                0.7071067811865476, 0.7071067811865476,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                0, 0,
                // Y-axis-parallel line, left-hand from Y-axis
                2, 2,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                1.0000019999995, 1.0000019999995,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1.372812945967288, 1.372812945967288,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                2, 2,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                2.121320343559643, 2.121320343559643,
                #endregion
            },
            // Point (-1, 1)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0.9999989999995, 0.9999989999995,
                // Passed through the origin line, at -11 degrees to the axis X
                0.7844645405527361, 0.7844645405527361,
                // Passed through the origin line, at -37 degrees to the axis X
                0.2, 0.2,
                // Passed through the origin line, at -45 degrees to the axis X
                0, 0,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                0, 0,
                // X-axis-parallel line, below X-axis
                2, 2,
                // Y-axis-parallel line, right-hand from Y-axis
                2, 2,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                0, 0,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                0, 0,
                #endregion
            },
            // Point (-1, -1)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                1, 1,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1.0000009999995, 1.0000009999995,
                // Passed through the origin line, at -11 degrees to the axis X
                1.1766968108291043, 1.1766968108291043,
                // Passed through the origin line, at -37 degrees to the axis X
                1.4, 1.4,
                // Passed through the origin line, at -45 degrees to the axis X
                1.4142135623730951, 1.4142135623730951,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                2, 2,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                2, 2,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1.9999999999990001, 1.9999999999990001,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                1.9611613513818402, 1.9611613513818402,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                1.6, 1.6,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                1.4142135623730951, 1.4142135623730951,
                #endregion
            },
            // Point (100, 0)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                0, 0,
                // On Y-axis line
                100, 100,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0.00009999999999995001, 0.00009999999999995001,
                // Passed through the origin line, at -11 degrees to the axis X
                19.6116135138184, 19.6116135138184,
                // Passed through the origin line, at -37 degrees to the axis X
                60, 60,
                // Passed through the origin line, at -45 degrees to the axis X
                70.71067811865476, 70.71067811865476,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                1, 1,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                99, 99,
                // Y-axis-parallel line, left-hand from Y-axis
                101, 101,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                1.0001009999994999, 1.0001009999994999,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                20.788310324647505, 20.788310324647505,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                61.4, 61.4,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                72.12489168102785, 72.12489168102785,
                #endregion
            },
            // Point (100, -1)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                1, 1,
                // On Y-axis line
                100, 100,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0.9998999999995, 0.9998999999995,
                // Passed through the origin line, at -11 degrees to the axis X
                18.63103283812748, 18.63103283812748,
                // Passed through the origin line, at -37 degrees to the axis X
                59.2, 59.2,
                // Passed through the origin line, at -45 degrees to the axis X
                70.00357133746822, 70.00357133746822,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                2, 2,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                99, 99,
                // Y-axis-parallel line, left-hand from Y-axis
                101, 101,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                2.0001009999990003, 2.0001009999990003,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                21.768891000338424, 21.768891000338424,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                62.2, 62.2,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                72.8319984622144, 72.8319984622144,
                #endregion
            },
            // Point (100, -2)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                2, 2,
                // On Y-axis line
                100, 100,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                1.9998999999990001, 1.9998999999990001,
                // Passed through the origin line, at -11 degrees to the axis X
                17.65045216243656, 17.65045216243656,
                // Passed through the origin line, at -37 degrees to the axis X
                58.4, 58.4,
                // Passed through the origin line, at -45 degrees to the axis X
                69.29646455628166, 69.29646455628166,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                3, 3,
                // X-axis-parallel line, below X-axis
                1, 1,
                // Y-axis-parallel line, right-hand from Y-axis
                99, 99,
                // Y-axis-parallel line, left-hand from Y-axis
                101, 101,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                3.0001009999984998, 3.0001009999984998,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                22.749471676029348, 22.749471676029348,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                63, 63,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                73.53910524340095, 73.53910524340095,
                #endregion
            },
            // Point (100, -3)
            new double[]
            {
                #region [ Passed through the origin lines ]
                // On X-axis line
                3, 3,
                // On Y-axis line
                100, 100,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                2.9998999999985, 2.9998999999985,
                // Passed through the origin line, at -11 degrees to the axis X
                16.66987148674564, 16.66987148674564,
                // Passed through the origin line, at -37 degrees to the axis X
                57.6, 57.6,
                // Passed through the origin line, at -45 degrees to the axis X
                68.58935777509511, 68.58935777509511,
                #endregion
                
                #region [ Axis-parallel lines ]
                // X-axis-parallel line, above X-axis
                4, 4,
                // X-axis-parallel line, below X-axis
                2, 2,
                // Y-axis-parallel line, right-hand from Y-axis
                99, 99,
                // Y-axis-parallel line, left-hand from Y-axis
                101, 101,
                #endregion
                
                #region [ Not passed through the origin lines, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second
                4.000100999998, 4.000100999998,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                23.730052351720268, 23.730052351720268,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                63.8, 63.8,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                74.24621202458749, 74.24621202458749,
                #endregion
            },
        };

        public static Vector?[][] Result_TwoLinesIntersectionPoints { get; } =
        {
            // On X-axis first line
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // On X-axis line
                null,
                // On Y-axis line
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion

                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                null,
                null,
                // X-axis-parallel line, below X-axis
                null,
                null,
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, 0),
                new Vector(1, 0),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0),
                new Vector(-1, 0),
                #endregion

                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1000001, 0),
                new Vector(-1000001, 0),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-6, 0),
                new Vector(-6, 0),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-2.333333333333333, 0),
                new Vector(-2.333333333333333, 0),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-2, 0),
                new Vector(-2, 0),
                #endregion
            },
            // On X-axis first line
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // On Y-axis line
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion

                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                null,
                null,
                // X-axis-parallel line, below X-axis
                null,
                null,
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, 0),
                new Vector(1, 0),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0),
                new Vector(-1, 0),
                #endregion

                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1000001, 0),
                new Vector(-1000001, 0),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-6, 0),
                new Vector(-6, 0),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-2.333333333333333, 0),
                new Vector(-2.333333333333333, 0),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-2, 0),
                new Vector(-2, 0),
                #endregion
            },
            // On Y-axis first line
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // On Y-axis line
                null,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(0, 1),
                new Vector(0, 1),
                // X-axis-parallel line, below X-axis
                new Vector(0, -1),
                new Vector(0, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                null,
                null,
                // Y-axis-parallel line, left-hand from Y-axis
                null,
                null,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(0, 1.000001),
                new Vector(0, 1.000001),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(0, 1.2),
                new Vector(0, 1.2),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(0, 1.75),
                new Vector(0, 1.75),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(0, 2),
                new Vector(0, 2),
                #endregion
            },
            // On Y-axis first line
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(0, 1),
                new Vector(0, 1),
                // X-axis-parallel line, below X-axis
                new Vector(0, -1),
                new Vector(0, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                null,
                null,
                // Y-axis-parallel line, left-hand from Y-axis
                null,
                null,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(0, 1.000001),
                new Vector(0, 1.000001),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(0, 1.2),
                new Vector(0, 1.2),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(0, 1.75),
                new Vector(0, 1.75),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(0, 2),
                new Vector(0, 2),
                #endregion
            },
            // Passed through the origin first line, at between 0 and -1 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                null,
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1000000, 1),
                new Vector(-1000000, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1000000, -1),
                new Vector(1000000, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1E-6),
                new Vector(1, -1E-6),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1E-6),
                new Vector(-1, 1E-6),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-500000.5, 0.5000005),
                new Vector(-500000.5, 0.5000005),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-5.99997000015, 5.99997000015E-6),
                new Vector(-5.99997000015, 5.99997000015E-6),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-2.333330222226, 2.333330222226E-6),
                new Vector(-2.333330222226, 2.333330222226E-6),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.999998000002, 1.999998000002E-6),
                new Vector(-1.999998000002, 1.999998000002E-6),
                #endregion
            },
            // Passed through the origin first line, at between 0 and -1 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -11 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1000000, 1),
                new Vector(-1000000, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1000000, -1),
                new Vector(1000000, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1E-6),
                new Vector(1, -1E-6),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1E-6),
                new Vector(-1, 1E-6),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-500000.5, 0.5000005),
                new Vector(-500000.5, 0.5000005),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-5.99997000015, 5.99997000015E-6),
                new Vector(-5.99997000015, 5.99997000015E-6),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-2.333330222226, 2.333330222226E-6),
                new Vector(-2.333330222226, 2.333330222226E-6),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.999998000002, 1.999998000002E-6),
                new Vector(-1.999998000002, 1.999998000002E-6),
                #endregion
            },
            // Passed through the origin first line, at -11 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -11 degrees to the axis X
                null,
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-5, 1),
                new Vector(-5, 1),
                // X-axis-parallel line, below X-axis
                new Vector(5, -1),
                new Vector(5, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -0.2),
                new Vector(1, -0.2),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0.2),
                new Vector(-1, 0.2),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-4.9999800001, 0.99999600002),
                new Vector(-4.9999800001, 0.99999600002),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-3, 0.6),
                new Vector(-3, 0.6),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1.842105263158, 0.3684210526316),
                new Vector(-1.842105263158, 0.3684210526316),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.666666666667, 0.3333333333333),
                new Vector(-1.666666666667, 0.3333333333333),
                #endregion
            },
            // Passed through the origin first line, at -11 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -37 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-5, 1),
                new Vector(-5, 1),
                // X-axis-parallel line, below X-axis
                new Vector(5, -1),
                new Vector(5, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -0.2),
                new Vector(1, -0.2),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0.2),
                new Vector(-1, 0.2),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-4.9999800001, 0.99999600002),
                new Vector(-4.9999800001, 0.99999600002),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-3, 0.6),
                new Vector(-3, 0.6),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1.842105263158, 0.3684210526316),
                new Vector(-1.842105263158, 0.3684210526316),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.666666666667, 0.3333333333333),
                new Vector(-1.666666666667, 0.3333333333333),
                #endregion
            },
            // Passed through the origin first line, at -37 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -37 degrees to the axis X
                null,
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1.333333333333333, 1),
                new Vector(-1.333333333333333, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1.333333333333333, -1),
                new Vector(1.333333333333333, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -0.75),
                new Vector(1, -0.75),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0.75),
                new Vector(-1, 0.75),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1.333332888889, 0.9999996666671),
                new Vector(-1.333332888889, 0.9999996666671),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1.263157894737, 0.9473684210526),
                new Vector(-1.263157894737, 0.9473684210526),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1.166666666667, 0.875),
                new Vector(-1.166666666667, 0.875),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.142857142857, 0.8571428571429),
                new Vector(-1.142857142857, 0.8571428571429),
                #endregion
            },
            // Passed through the origin first line, at -37 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -45 degrees to the axis X
                new Vector(0, 0),
                new Vector(0, 0),
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1.333333333333333, 1),
                new Vector(-1.333333333333333, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1.333333333333333, -1),
                new Vector(1.333333333333333, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -0.75),
                new Vector(1, -0.75),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 0.75),
                new Vector(-1, 0.75),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1.333332888889, 0.9999996666671),
                new Vector(-1.333332888889, 0.9999996666671),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1.263157894737, 0.9473684210526),
                new Vector(-1.263157894737, 0.9473684210526),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1.166666666667, 0.875),
                new Vector(-1.166666666667, 0.875),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1.142857142857, 0.8571428571429),
                new Vector(-1.142857142857, 0.8571428571429),
                #endregion
            },
            // Passed through the origin first line, at -45 degrees to the axis X
            new Vector?[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -45 degrees to the axis X
                null,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Passed through the origin first line, at -45 degrees to the axis X
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                // X-axis-parallel line, below X-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // X-axis-parallel first line, above X-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                null,
                // X-axis-parallel line, below X-axis
                null,
                null,
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, 1),
                new Vector(1, 1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // X-axis-parallel first line, above X-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, below X-axis
                null,
                null,
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, 1),
                new Vector(1, 1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // X-axis-parallel first line, below X-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, below X-axis
                null,
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, -1),
                new Vector(-1, -1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-2000001, -1),
                new Vector(-2000001, -1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-11, -1),
                new Vector(-11, -1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-3.666666666667, -1),
                new Vector(-3.666666666667, -1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-3, -1),
                new Vector(-3, -1),
                #endregion
            },
            // X-axis-parallel first line, below X-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, right-hand from Y-axis
                new Vector(1, -1),
                new Vector(1, -1),
                // Y-axis-parallel line, left-hand from Y-axis
                new Vector(-1, -1),
                new Vector(-1, -1),
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-2000001, -1),
                new Vector(-2000001, -1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-11, -1),
                new Vector(-11, -1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-3.666666666667, -1),
                new Vector(-3.666666666667, -1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-3, -1),
                new Vector(-3, -1),
                #endregion
            },
            // Y-axis-parallel first line, right-hand from Y-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, right-hand from Y-axis
                null,
                // Y-axis-parallel line, left-hand from Y-axis
                null,
                null,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(1, 1.000002),
                new Vector(1, 1.000002),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(1, 1.4),
                new Vector(1, 1.4),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(1, 2.5),
                new Vector(1, 2.5),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(1, 3),
                new Vector(1, 3),
                #endregion
            },
            // Y-axis-parallel first line, right-hand from Y-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, left-hand from Y-axis
                null,
                null,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(1, 1.000002),
                new Vector(1, 1.000002),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(1, 1.4),
                new Vector(1, 1.4),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(1, 2.5),
                new Vector(1, 2.5),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(1, 3),
                new Vector(1, 3),
                #endregion
            },
            // Y-axis-parallel first line, left-hand from Y-axis
            new Vector?[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, left-hand from Y-axis
                null,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Y-axis-parallel first line, left-hand from Y-axis
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at between 0 and 1 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                null,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at between 0 and 1 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at 11 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                null,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at 11 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at 37 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                null,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at 37 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                new Vector(-1, 1),
                new Vector(-1, 1),
                #endregion
            },
            // Not passed through the origin first line, at 45 degrees to the axis X, second quarter
            new Vector?[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                null,
                #endregion
            }
        };

        public static bool[][] Result_AreTwoLinesParallel { get; } =
        {
            #region [ Passed through the origin first line ]
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, true, true, true, true, false, false, false, false, false,
                false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                true, true, true, true, false, false, false, false, false, false,
                false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, true, true, true, true, false, false, false,
                false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, true, true, true, true, false, false, false, false,
                false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false },
            #endregion

            #region [ Axis-parallel first line ]
            new bool[] { true, true, true, false, false, false, false, false, false, false,
                false, false, false, false, false },
            new bool[] { true, true, false, false, false, false, false, false, false, false,
                false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false },
            new bool[] { true, true, true, false, false, false, false, false, false, false,
                false },
            new bool[] { true, true, false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false },
            #endregion

            #region [ Not passed through the origin first line, second quarter ]
            new bool[] { true, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false },
            new bool[] { true, false, false, false, false },
            new bool[] { false, false, false, false },
            new bool[] { true, false, false },
            new bool[] { false, false },
            new bool[] { true },
            #endregion
        };

        public static bool[][] Result_AreTwoLinesMatching { get; } =
        {
            #region [ Passed through the origin first line ]
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false },
            #endregion

            #region [ Axis-parallel first line ]
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false },
            new bool[] { true, false, false, false, false, false, false, false, false, false,
                false },
            new bool[] { false, false, false, false, false, false, false, false, false, false },
            new bool[] { true, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false },
            #endregion

            #region [ Not passed through the origin first line, second quarter ]
            new bool[] { true, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false },
            new bool[] { true, false, false, false, false },
            new bool[] { false, false, false, false },
            new bool[] { true, false, false },
            new bool[] { false, false },
            new bool[] { true },
            #endregion
        };

        public static bool[][] Result_AreTwoLinesPerpendicular { get; } =
        {
            #region [ Passed through the origin first line ]
            new bool[] { false, true, true, false, false, false, false, false, false, false,
                false, false, false, false, false, true, true, true, true, false,
                false, false, false, false, false, false, false },
            new bool[] { true, true, false, false, false, false, false, false, false, false,
                false, false, false, false, true, true, true, true, false, false,
                false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, true,
                true, true, true, false, false, false, false, false, false, false,
                false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, true, true,
                true, true, false, false, false, false, false, false, false, false,
                false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false,
                false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, false, true, true },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false, false, false, false, true, true },
            #endregion

            #region [ Axis-parallel first line ]
            new bool[] { false, false, false, true, true, true, true, false, false, false,
                false, false, false, false, false },
            new bool[] { false, false, true, true, true, true, false, false, false, false,
                false, false, false, false },
            new bool[] { false, true, true, true, true, false, false, false, false, false,
                false, false, false },
            new bool[] { true, true, true, true, false, false, false, false, false, false,
                false, false },
            new bool[] { false, false, false, false, false, false, false, false, false, false,
                false },
            new bool[] { false, false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false, false, false },
            #endregion

            #region [ Not passed through the origin first line, second quarter ]
            new bool[] { false, false, false, false, false, false, false },
            new bool[] { false, false, false, false, false, false },
            new bool[] { false, false, false, false, false },
            new bool[] { false, false, false, false },
            new bool[] { false, false, false },
            new bool[] { false, false },
            new bool[] { false },
            #endregion
        };

        public static double[][] Result_BetweenTwoLinesAngles { get; } =
        {
            // On X-axis first line
            new double[]
            {
                #region [ Passed through the origin second line ]
                // On X-axis line
                0,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0.000057298, 0.000057298,
                // Passed through the origin line, at -11 degrees to the axis X
                11.309932474, 11.309932474,
                // Passed through the origin line, at -37 degrees to the axis X
                36.869897646, 36.869897646,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                0, 0,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // On X-axis first line
            new double[]
            {
                #region [ Passed through the origin second line ]
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0.000057298, 0.000057298,
                // Passed through the origin line, at -11 degrees to the axis X
                11.309932474, 11.309932474,
                // Passed through the origin line, at -37 degrees to the axis X
                36.869897646, 36.869897646,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                0, 0,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // On Y-axis first line
            new double[]
            {
                #region [ Passed through the origin second line ]
                // On Y-axis line
                0,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942704, 89.999942704,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                0, 0,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // On Y-axis first line
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942704, 89.999942704,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                0, 0,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Passed through the origin first line, at between 0 and -1 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                0,
                // Passed through the origin line, at -11 degrees to the axis X
                11.309875178, 11.309875178,
                // Passed through the origin line, at -37 degrees to the axis X
                36.86984035, 36.86984035,
                // Passed through the origin line, at -45 degrees to the axis X
                44.999942704, 44.999942704,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                0.000057298, 0.000057298,
                // X-axis-parallel line, below X-axis
                0.000057298, 0.000057298,
                // Y-axis-parallel line, right-hand from Y-axis
                89.999942704, 89.999942704,
                // Y-axis-parallel line, left-hand from Y-axis
                89.999942704, 89.999942704,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.00011459, 0.00011459,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.30998977, 11.30998977,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869954942, 36.869954942,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45.000057296, 45.000057296,
                #endregion
            },
            // Passed through the origin first line, at between 0 and -1 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -11 degrees to the axis X
                11.309875178, 11.309875178,
                // Passed through the origin line, at -37 degrees to the axis X
                36.86984035, 36.86984035,
                // Passed through the origin line, at -45 degrees to the axis X
                44.999942704, 44.999942704,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                0.000057298, 0.000057298,
                // X-axis-parallel line, below X-axis
                0.000057298, 0.000057298,
                // Y-axis-parallel line, right-hand from Y-axis
                89.999942704, 89.999942704,
                // Y-axis-parallel line, left-hand from Y-axis
                89.999942704, 89.999942704,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.00011459, 0.00011459,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.30998977, 11.30998977,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869954942, 36.869954942,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45.000057296, 45.000057296,
                #endregion
            },
            // Passed through the origin first line, at -11 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -11 degrees to the axis X
                0,
                // Passed through the origin line, at -37 degrees to the axis X
                25.559965172, 25.559965172,
                // Passed through the origin line, at -45 degrees to the axis X
                33.690067526, 33.690067526,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                11.309932474, 11.309932474,
                // X-axis-parallel line, below X-axis
                11.309932474, 11.309932474,
                // Y-axis-parallel line, right-hand from Y-axis
                78.690067526, 78.690067526,
                // Y-axis-parallel line, left-hand from Y-axis
                78.690067526, 78.690067526,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                11.30998977, 11.30998977,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                22.619864948, 22.619864948,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                48.17983012, 48.17983012,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                #endregion
            },
            // Passed through the origin first line, at -11 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -37 degrees to the axis X
                25.559965172, 25.559965172,
                // Passed through the origin line, at -45 degrees to the axis X
                33.690067526, 33.690067526,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                11.309932474, 11.309932474,
                // X-axis-parallel line, below X-axis
                11.309932474, 11.309932474,
                // Y-axis-parallel line, right-hand from Y-axis
                78.690067526, 78.690067526,
                // Y-axis-parallel line, left-hand from Y-axis
                78.690067526, 78.690067526,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                11.30998977, 11.30998977,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                22.619864948, 22.619864948,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                48.17983012, 48.17983012,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                #endregion
            },
            // Passed through the origin first line, at -37 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -37 degrees to the axis X
                0,
                // Passed through the origin line, at -45 degrees to the axis X
                8.130102354, 8.130102354,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                36.869897646, 36.869897646,
                // X-axis-parallel line, below X-axis
                36.869897646, 36.869897646,
                // Y-axis-parallel line, right-hand from Y-axis
                53.130102354, 53.130102354,
                // Y-axis-parallel line, left-hand from Y-axis
                53.130102354, 53.130102354,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                36.869954942, 36.869954942,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                48.17983012, 48.17983012,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                73.739795292, 73.739795292,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                #endregion
            },
            // Passed through the origin first line, at -37 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -45 degrees to the axis X
                8.130102354, 8.130102354,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                36.869897646, 36.869897646,
                // X-axis-parallel line, below X-axis
                36.869897646, 36.869897646,
                // Y-axis-parallel line, right-hand from Y-axis
                53.130102354, 53.130102354,
                // Y-axis-parallel line, left-hand from Y-axis
                53.130102354, 53.130102354,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                36.869954942, 36.869954942,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                48.17983012, 48.17983012,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                73.739795292, 73.739795292,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                #endregion
            },
            // Passed through the origin first line, at -45 degrees to the axis X
            new double[]
            {
                #region [ Passed through the origin second line ]
                // Passed through the origin line, at -45 degrees to the axis X
                0,
                #endregion
                
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                45, 45,
                // X-axis-parallel line, below X-axis
                45, 45,
                // Y-axis-parallel line, right-hand from Y-axis
                45, 45,
                // Y-axis-parallel line, left-hand from Y-axis
                45, 45,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                45.000057296, 45.000057296,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                90, 90,
                #endregion
            },
            // Passed through the origin first line, at -45 degrees to the axis X
            new double[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                45, 45,
                // X-axis-parallel line, below X-axis
                45, 45,
                // Y-axis-parallel line, right-hand from Y-axis
                45, 45,
                // Y-axis-parallel line, left-hand from Y-axis
                45, 45,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                45.000057296, 45.000057296,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                90, 90,
                #endregion
            },
            // X-axis-parallel first line, above X-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, above X-axis
                0,
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // X-axis-parallel first line, above X-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, below X-axis
                0, 0,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // X-axis-parallel first line, below X-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // X-axis-parallel line, below X-axis
                0,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // X-axis-parallel first line, below X-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0.000057298, 0.000057298,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309932474, 11.309932474,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.869897646, 36.869897646,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Y-axis-parallel first line, right-hand from Y-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, right-hand from Y-axis
                0,
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Y-axis-parallel first line, right-hand from Y-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, left-hand from Y-axis
                0, 0,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Y-axis-parallel first line, left-hand from Y-axis
            new double[]
            {
                #region [ Axis-parallel second line ]
                // Y-axis-parallel line, left-hand from Y-axis
                0,
                #endregion
                
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Y-axis-parallel first line, left-hand from Y-axis
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                89.999942704, 89.999942704,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                78.690067526, 78.690067526,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                53.130102354, 53.130102354,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                45, 45,
                #endregion
            },
            // Not passed through the origin first line, at between 0 and 1 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at between 0 and 1 degrees to the axis X, second quarter
                0,
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309875178, 11.309875178,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.86984035, 36.86984035,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                44.999942704, 44.999942704,
                #endregion
            },
            // Not passed through the origin first line, at between 0 and 1 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                11.309875178, 11.309875178,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                36.86984035, 36.86984035,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                44.999942704, 44.999942704,
                #endregion
            },
            // Not passed through the origin first line, at 11 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 11 degrees to the axis X, second quarter
                0,
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                25.559965172, 25.559965172,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                33.690067526, 33.690067526,
                #endregion
            },
            // Not passed through the origin first line, at 11 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                25.559965172, 25.559965172,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                33.690067526, 33.690067526,
                #endregion
            },
            // Not passed through the origin first line, at 37 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 37 degrees to the axis X, second quarter
                0,
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                8.130102354, 8.130102354,
                #endregion            
            },
            // Not passed through the origin first line, at 37 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                8.130102354, 8.130102354,
                #endregion
            },
            // Not passed through the origin first line, at 45 degrees to the axis X, second quarter
            new double[]
            {
                #region [ Not passed through the origin second line, second quarter ]
                // Not passed through the origin line, at 45 degrees to the axis X, second quarter
                0,
                #endregion
            },
        };

        public static double[][] Result_BetweenTwoReversedVectorsAngles { get; } =
        {
            // On X-axis first line vector
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On X-axis first line vector
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis first line vector
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis first line vector
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On passed through the origin first line vector, at between 0 and -1 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                179.999942702, 179.999942702,
                // On Y-axis line
                89.999942702, 89.999942702,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690124824, 168.690124824,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130159652, 143.130159652,
                // Passed through the origin line, at -45 degrees to the axis X
                44.999942702, 44.999942702,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                179.999942702, 179.999942702,
                // X-axis-parallel line, below X-axis
                179.999942702, 179.999942702,
                // Y-axis-parallel line, right-hand from Y-axis
                89.999942702, 89.999942702,
                // Y-axis-parallel line, left-hand from Y-axis
                89.999942702, 89.999942702,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999885404, 179.999885404,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690010228, 168.690010228,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130045056, 143.130045056,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                134.999942702, 134.999942702,
                #endregion
            },
            // On passed through the origin first line vector, at between 0 and -1 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                179.999942702, 179.999942702,
                // On Y-axis line
                89.999942702, 89.999942702,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690124824, 168.690124824,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130159652, 143.130159652,
                // Passed through the origin line, at -45 degrees to the axis X
                44.999942702, 44.999942702,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                179.999942702, 179.999942702,
                // X-axis-parallel line, below X-axis
                179.999942702, 179.999942702,
                // Y-axis-parallel line, right-hand from Y-axis
                89.999942702, 89.999942702,
                // Y-axis-parallel line, left-hand from Y-axis
                89.999942702, 89.999942702,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999885404, 179.999885404,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690010228, 168.690010228,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130045056, 143.130045056,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                134.999942702, 134.999942702,
                #endregion
            },
            // On passed through the origin first line vector, at -11 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                168.690067526, 168.690067526,
                // On Y-axis line
                78.690067526, 78.690067526,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                168.690124824, 168.690124824,
                // Passed through the origin line, at -11 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -37 degrees to the axis X
                154.440034828, 154.440034828,
                // Passed through the origin line, at -45 degrees to the axis X
                33.690067526, 33.690067526,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                168.690067526, 168.690067526,
                // X-axis-parallel line, below X-axis
                168.690067526, 168.690067526,
                // Y-axis-parallel line, right-hand from Y-axis
                78.690067526, 78.690067526,
                // Y-axis-parallel line, left-hand from Y-axis
                78.690067526, 78.690067526,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                168.690010228, 168.690010228,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                157.380135052, 157.380135052,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                131.82016988, 131.82016988,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                123.690067526, 123.690067526,
                #endregion
            },
            // On passed through the origin first line vector, at -11 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                168.690067526, 168.690067526,
                // On Y-axis line
                78.690067526, 78.690067526,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                168.690124824, 168.690124824,
                // Passed through the origin line, at -11 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -37 degrees to the axis X
                154.440034828, 154.440034828,
                // Passed through the origin line, at -45 degrees to the axis X
                33.690067526, 33.690067526,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                168.690067526, 168.690067526,
                // X-axis-parallel line, below X-axis
                168.690067526, 168.690067526,
                // Y-axis-parallel line, right-hand from Y-axis
                78.690067526, 78.690067526,
                // Y-axis-parallel line, left-hand from Y-axis
                78.690067526, 78.690067526,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                168.690010228, 168.690010228,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                157.380135052, 157.380135052,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                131.82016988, 131.82016988,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                123.690067526, 123.690067526,
                #endregion
            },
            // On passed through the origin first line vector, at -37 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                143.130102354, 143.130102354,
                // On Y-axis line
                53.130102354, 53.130102354,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                143.130159652, 143.130159652,
                // Passed through the origin line, at -11 degrees to the axis X
                154.440034828, 154.440034828,
                // Passed through the origin line, at -37 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -45 degrees to the axis X
                8.130102354, 8.130102354,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                143.130102354, 143.130102354,
                // X-axis-parallel line, below X-axis
                143.130102354, 143.130102354,
                // Y-axis-parallel line, right-hand from Y-axis
                53.130102354, 53.130102354,
                // Y-axis-parallel line, left-hand from Y-axis
                53.130102354, 53.130102354,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                143.130045056, 143.130045056,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                131.82016988, 131.82016988,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                106.260204708, 106.260204708,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                98.130102354, 98.130102354,
                #endregion
            },
            // On passed through the origin first line vector, at -37 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                143.130102354, 143.130102354,
                // On Y-axis line
                53.130102354, 53.130102354,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                143.130159652, 143.130159652,
                // Passed through the origin line, at -11 degrees to the axis X
                154.440034828, 154.440034828,
                // Passed through the origin line, at -37 degrees to the axis X
                180, 180,
                // Passed through the origin line, at -45 degrees to the axis X
                8.130102354, 8.130102354,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                143.130102354, 143.130102354,
                // X-axis-parallel line, below X-axis
                143.130102354, 143.130102354,
                // Y-axis-parallel line, right-hand from Y-axis
                53.130102354, 53.130102354,
                // Y-axis-parallel line, left-hand from Y-axis
                53.130102354, 53.130102354,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                143.130045056, 143.130045056,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                131.82016988, 131.82016988,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                106.260204708, 106.260204708,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                98.130102354, 98.130102354,
                #endregion
            },
            // On passed through the origin first line vector, at -45 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                45, 45,
                // On Y-axis line
                135, 135,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                44.999942702, 44.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                33.690067526, 33.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                8.130102354, 8.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                180, 180,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                45, 45,
                // X-axis-parallel line, below X-axis
                45, 45,
                // Y-axis-parallel line, right-hand from Y-axis
                135, 135,
                // Y-axis-parallel line, left-hand from Y-axis
                135, 135,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                45.000057298, 45.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                90, 90,
                #endregion
            },
            // On passed through the origin first line vector, at -45 degrees to the axis X
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                45, 45,
                // On Y-axis line
                135, 135,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                44.999942702, 44.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                33.690067526, 33.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                8.130102354, 8.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                180, 180,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                45, 45,
                // X-axis-parallel line, below X-axis
                45, 45,
                // Y-axis-parallel line, right-hand from Y-axis
                135, 135,
                // Y-axis-parallel line, left-hand from Y-axis
                135, 135,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                45.000057298, 45.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                56.309932474, 56.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                81.869897646, 81.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                90, 90,
                #endregion
            },
            // On X-axis-parallel first line vector, above X-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On X-axis-parallel first line vector, above X-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On X-axis-parallel first line vector, below X-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On X-axis-parallel first line vector, below X-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                180, 180,
                // On Y-axis line
                90, 90,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999942702, 179.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690067526, 168.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130102354, 143.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                45, 45,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                180, 180,
                // X-axis-parallel line, below X-axis
                180, 180,
                // Y-axis-parallel line, right-hand from Y-axis
                90, 90,
                // Y-axis-parallel line, left-hand from Y-axis
                90, 90,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                179.999942702, 179.999942702,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690067526, 168.690067526,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130102354, 143.130102354,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis-parallel first line vector, right-hand from Y-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis-parallel first line vector, right-hand from Y-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis-parallel first line vector, left-hand from Y-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On Y-axis-parallel first line vector, left-hand from Y-axis
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                90, 90,
                // On Y-axis line
                180, 180,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                89.999942702, 89.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                78.690067526, 78.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                53.130102354, 53.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                135, 135,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                90, 90,
                // X-axis-parallel line, below X-axis
                90, 90,
                // Y-axis-parallel line, right-hand from Y-axis
                180, 180,
                // Y-axis-parallel line, left-hand from Y-axis
                180, 180,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                90.000057298, 90.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                101.309932474, 101.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                126.869897646, 126.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135, 135,
                #endregion
            },
            // On not passed through the origin first line vector, at between 0 and 1 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                179.999942702, 179.999942702,
                // On Y-axis line
                90.000057298, 90.000057298,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999885404, 179.999885404,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690010228, 168.690010228,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130045056, 143.130045056,
                // Passed through the origin line, at -45 degrees to the axis X
                45.000057298, 45.000057298,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                179.999942702, 179.999942702,
                // X-axis-parallel line, below X-axis
                179.999942702, 179.999942702,
                // Y-axis-parallel line, right-hand from Y-axis
                90.000057298, 90.000057298,
                // Y-axis-parallel line, left-hand from Y-axis
                90.000057298, 90.000057298,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690124824, 168.690124824,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130159652, 143.130159652,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135.000057298, 135.000057298,
                #endregion
            },
            // On not passed through the origin first line vector, at between 0 and 1 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                179.999942702, 179.999942702,
                // On Y-axis line
                90.000057298, 90.000057298,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                179.999885404, 179.999885404,
                // Passed through the origin line, at -11 degrees to the axis X
                168.690010228, 168.690010228,
                // Passed through the origin line, at -37 degrees to the axis X
                143.130045056, 143.130045056,
                // Passed through the origin line, at -45 degrees to the axis X
                45.000057298, 45.000057298,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                179.999942702, 179.999942702,
                // X-axis-parallel line, below X-axis
                179.999942702, 179.999942702,
                // Y-axis-parallel line, right-hand from Y-axis
                90.000057298, 90.000057298,
                // Y-axis-parallel line, left-hand from Y-axis
                90.000057298, 90.000057298,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                168.690124824, 168.690124824,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                143.130159652, 143.130159652,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                135.000057298, 135.000057298,
                #endregion
            },
            // On not passed through the origin first line vector, at 11 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                168.690067526, 168.690067526,
                // On Y-axis line
                101.309932474, 101.309932474,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                168.690010228, 168.690010228,
                // Passed through the origin line, at -11 degrees to the axis X
                157.380135052, 157.380135052,
                // Passed through the origin line, at -37 degrees to the axis X
                131.82016988, 131.82016988,
                // Passed through the origin line, at -45 degrees to the axis X
                56.309932474, 56.309932474,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                168.690067526, 168.690067526,
                // X-axis-parallel line, below X-axis
                168.690067526, 168.690067526,
                // Y-axis-parallel line, right-hand from Y-axis
                101.309932474, 101.309932474,
                // Y-axis-parallel line, left-hand from Y-axis
                101.309932474, 101.309932474,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                168.690124824, 168.690124824,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                154.440034828, 154.440034828,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                146.309932474, 146.309932474,
                #endregion
            },
            // On not passed through the origin first line vector, at 11 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                168.690067526, 168.690067526,
                // On Y-axis line
                101.309932474, 101.309932474,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                168.690010228, 168.690010228,
                // Passed through the origin line, at -11 degrees to the axis X
                157.380135052, 157.380135052,
                // Passed through the origin line, at -37 degrees to the axis X
                131.82016988, 131.82016988,
                // Passed through the origin line, at -45 degrees to the axis X
                56.309932474, 56.309932474,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                168.690067526, 168.690067526,
                // X-axis-parallel line, below X-axis
                168.690067526, 168.690067526,
                // Y-axis-parallel line, right-hand from Y-axis
                101.309932474, 101.309932474,
                // Y-axis-parallel line, left-hand from Y-axis
                101.309932474, 101.309932474,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                168.690124824, 168.690124824,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                154.440034828, 154.440034828,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                146.309932474, 146.309932474,
                #endregion
            },
            // On not passed through the origin first line vector, at 37 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                143.130102354, 143.130102354,
                // On Y-axis line
                126.869897646, 126.869897646,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                143.130045056, 143.130045056,
                // Passed through the origin line, at -11 degrees to the axis X
                131.82016988, 131.82016988,
                // Passed through the origin line, at -37 degrees to the axis X
                106.260204708, 106.260204708,
                // Passed through the origin line, at -45 degrees to the axis X
                81.869897646, 81.869897646,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                143.130102354, 143.130102354,
                // X-axis-parallel line, below X-axis
                143.130102354, 143.130102354,
                // Y-axis-parallel line, right-hand from Y-axis
                126.869897646, 126.869897646,
                // Y-axis-parallel line, left-hand from Y-axis
                126.869897646, 126.869897646,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                143.130159652, 143.130159652,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                154.440034828, 154.440034828,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                171.869897646, 171.869897646,
                #endregion
            },
            // On not passed through the origin first line vector, at 37 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                143.130102354, 143.130102354,
                // On Y-axis line
                126.869897646, 126.869897646,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                143.130045056, 143.130045056,
                // Passed through the origin line, at -11 degrees to the axis X
                131.82016988, 131.82016988,
                // Passed through the origin line, at -37 degrees to the axis X
                106.260204708, 106.260204708,
                // Passed through the origin line, at -45 degrees to the axis X
                81.869897646, 81.869897646,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                143.130102354, 143.130102354,
                // X-axis-parallel line, below X-axis
                143.130102354, 143.130102354,
                // Y-axis-parallel line, right-hand from Y-axis
                126.869897646, 126.869897646,
                // Y-axis-parallel line, left-hand from Y-axis
                126.869897646, 126.869897646,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                143.130159652, 143.130159652,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                154.440034828, 154.440034828,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                180, 180,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                171.869897646, 171.869897646,
                #endregion
            },
            // On not passed through the origin first line vector, at 45 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                135, 135,
                // On Y-axis line
                135, 135,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                134.999942702, 134.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                123.690067526, 123.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                98.130102354, 98.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                90, 90,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                135, 135,
                // X-axis-parallel line, below X-axis
                135, 135,
                // Y-axis-parallel line, right-hand from Y-axis
                135, 135,
                // Y-axis-parallel line, left-hand from Y-axis
                135, 135,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                135.000057298, 135.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                146.309932474, 146.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                171.869897646, 171.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                180, 180,
                #endregion
            },
            // On not passed through the origin first line vector, at 45 degrees to the axis X, second quarter
            new double[]
            {
                #region [ On passed through the origin second line vector ]
                // On X-axis line
                135, 135,
                // On Y-axis line
                135, 135,
                // Passed through the origin line, at between 0 and -1 degrees to the axis X
                134.999942702, 134.999942702,
                // Passed through the origin line, at -11 degrees to the axis X
                123.690067526, 123.690067526,
                // Passed through the origin line, at -37 degrees to the axis X
                98.130102354, 98.130102354,
                // Passed through the origin line, at -45 degrees to the axis X
                90, 90,
                #endregion
                
                #region [ On axis-parallel second line vector ]
                // X-axis-parallel line, above X-axis
                135, 135,
                // X-axis-parallel line, below X-axis
                135, 135,
                // Y-axis-parallel line, right-hand from Y-axis
                135, 135,
                // Y-axis-parallel line, left-hand from Y-axis
                135, 135,
                #endregion
                
                #region [ On not passed through the origin second line vector, second quarter ]
                // Not passed through the origin vector, at between 0 and 1 degrees to the axis X, second quarter
                135.000057298, 135.000057298,
                // Not passed through the origin vector, at 11 degrees to the axis X, second quarter
                146.309932474, 146.309932474,
                // Not passed through the origin vector, at 37 degrees to the axis X, second quarter
                171.869897646, 171.869897646,
                // Not passed through the origin vector, at 45 degrees to the axis X, second quarter
                180, 180,
                #endregion
            },
        };

        public static Vector[][] Result_AdditionResultVectors { get; } =
        {
            // null
            new Vector[]{},
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(1.9998476951564, -0.01745240643728),
                new Vector(1.7071067811865, 0.7071067811865),
                new Vector(1.8660254037844, -0.5),
                new Vector(1, 1),
                new Vector(0.0038053019083, 0.08715574274766),
                new Vector(0.0038053019083, -0.08715574274766),
                new Vector(0, 0),
                new Vector(2, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector[]
            {
                new Vector(1.706954476343, 0.6896543747492),
                new Vector(1.865873098941, -0.51745240643728),
                new Vector(0.9998476951564, 0.9825475935627),
                new Vector(0.0036529970647, 0.06970333631038),
                new Vector(0.0036529970647, -0.1046081491849),
                new Vector(-0.0001523048436, -0.01745240643728),
                new Vector(1.9998476951564, -0.01745240643728),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector[]
            {
                new Vector(1.573132184971, 0.2071067811865),
                new Vector(0.7071067811865, 1.7071067811865),
                new Vector(-0.2890879169052, 0.7942625239342),
                new Vector(-0.2890879169052, 0.6199510384388),
                new Vector(-0.2928932188135, 0.7071067811865),
                new Vector(1.7071067811865, 0.7071067811865),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector[]
            {
                new Vector(0.8660254037844, 0.5),
                new Vector(-0.1301692943073, -0.4128442572523),
                new Vector(-0.1301692943073, -0.58715574274766),
                new Vector(-0.1339745962156, -0.5),
                new Vector(1.8660254037844, -0.5),
            },
            // Vector(0, 1)
            new Vector[]
            {
                new Vector(-0.9961946980917, 1.08715574274766),
                new Vector(-0.9961946980917, 0.9128442572523),
                new Vector(-1, 1),
                new Vector(1, 1),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector[]
            {
                new Vector(-1.992389396183, 0),
                new Vector(-1.9961946980917, 0.08715574274766),
                new Vector(0.0038053019083, 0.08715574274766),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector[]
            {
                new Vector(-1.9961946980917, -0.08715574274766),
                new Vector(0.0038053019083, -0.08715574274766),
            },
            // new Vector(-1, 0)
            new Vector[]
            {
                new Vector(0, 0),
            },
        };

        public static Vector[][] Result_SubtractionResultVectors { get; } =
        {
            // null
            new Vector[]{},
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(0.0001523048436, 0.01745240643728),
                new Vector(0.2928932188135, -0.7071067811865),
                new Vector(0.1339745962156, 0.5),
                new Vector(1, -1),
                new Vector(1.9961946980917, -0.08715574274766),
                new Vector(1.9961946980917, 0.08715574274766),
                new Vector(2, 0),
                new Vector(0, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector[]
            {
                new Vector(0.2927409139699, -0.7245591876238),
                new Vector(0.133822291372, 0.4825475935627),
                new Vector(0.9998476951564, -1.01745240643728),
                new Vector(1.996042393248, -0.1046081491849),
                new Vector(1.996042393248, 0.06970333631038),
                new Vector(1.9998476951564, -0.01745240643728),
                new Vector(-0.0001523048436, -0.01745240643728),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector[]
            {
                new Vector(-0.1589186225979, 1.207106781187),
                new Vector(0.7071067811865, -0.2928932188135),
                new Vector(1.703301479278, 0.6199510384388),
                new Vector(1.703301479278, 0.7942625239342),
                new Vector(1.7071067811865, 0.7071067811865),
                new Vector(-0.2928932188135, 0.7071067811865),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector[]
            {
                new Vector(0.8660254037844, -1.5),
                new Vector(1.862220101876, -0.5871557427477),
                new Vector(1.862220101876, -0.4128442572523),
                new Vector(1.866025403784, -0.5),
                new Vector(-0.1339745962156, -0.5),
            },
            // Vector(0, 1)
            new Vector[]
            {
                new Vector(0.9961946980917, 0.9128442572523),
                new Vector(0.9961946980917, 1.08715574274766),
                new Vector(1, 1),
                new Vector(-1, 1),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector[]
            {
                new Vector(0, 0.1743114854953),
                new Vector(0.0038053019083, 0.08715574274766),
                new Vector(-1.9961946980917, 0.08715574274766),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector[]
            {
                new Vector(0.0038053019083, -0.08715574274766),
                new Vector(-1.996194698092, -0.08715574274766),
            },
            // new Vector(-1, 0)
            new Vector[]
            {
                new Vector(-2, 0),
            },
        };

        public static Vector[][] Result_MultiplicationWithDoubleResultVectors { get; } =
        {
            // null
            new Vector[]{},
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(1, 0),
                new Vector(-99.09, 0),
                new Vector(0.1, 0),
                new Vector(-0.00000001, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.9998476951564, -0.01745240643728),
                new Vector(-99.07490811305, 1.72935895387),
                new Vector(0.09998476951564, -0.001745240643728),
                new Vector(-9.998476951564E-9, 1.745240643728E-10),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.7071067811865, 0.7071067811865),
                new Vector(-70.06721094777, -70.06721094777),
                new Vector(0.07071067811865, 0.07071067811865),
                new Vector(-7.071067811865E-9, -7.071067811865E-9),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.8660254037844, -0.5),
                new Vector(-85.814457261, 49.545),
                new Vector(0.08660254037844, -0.05),
                new Vector(-8.660254037844E-9, 5E-9),
            },
            // Vector(0, 1)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0, 1),
                new Vector(0, -99.09),
                new Vector(0, 0.1),
                new Vector(0, -0.00000001),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-0.9961946980917, 0.08715574274766),
                new Vector(98.71293263391, -8.636262548866),
                new Vector(-0.09961946980917, 0.008715574274766),
                new Vector(9.961946980917E-9, -8.715574274766E-10),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-0.9961946980917, -0.08715574274766),
                new Vector(98.71293263391, 8.636262548866),
                new Vector(-0.09961946980917, -0.008715574274766),
                new Vector(9.961946980917E-9, 8.715574274766E-10),
            },
            // Vector(-1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-1, 0),
                new Vector(99.09, 0),
                new Vector(-0.1, 0),
                new Vector(0.00000001, 0),
            },
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(1, 0),
                new Vector(-99.09, 0),
                new Vector(0.1, 0),
                new Vector(-0.00000001, 0),
            },
        };

        public static Vector[][] Result_MultiplicationWithIntegerResultVectors { get; } =
        {
            // null
            new Vector[]{},
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(1, 0),
                new Vector(-1, 0),
                new Vector(100000, 0),
                new Vector(-505, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.9998476951564, -0.01745240643728),
                new Vector(-0.9998476951564, 0.01745240643728),
                new Vector(99984.76951564, -1745.240643728),
                new Vector(-504.923086054, 8.813465250826),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.7071067811865, 0.7071067811865),
                new Vector(-0.7071067811865, -0.7071067811865),
                new Vector(70710.67811865, 70710.67811865),
                new Vector(-357.0889244992, -357.0889244992),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0.8660254037844, -0.5),
                new Vector(-0.8660254037844, 0.5),
                new Vector(86602.54037844, -50000),
                new Vector(-437.3428289111, 252.5),
            },
            // Vector(0, 1)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(0, 1),
                new Vector(0, -1),
                new Vector(0, 100000),
                new Vector(0, -505),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-0.9961946980917, 0.08715574274766),
                new Vector(0.9961946980917, -0.08715574274766),
                new Vector(-99619.46980917, 8715.574274766),
                new Vector(503.0783225363, -44.01365008757),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-0.9961946980917, -0.08715574274766),
                new Vector(0.9961946980917, 0.08715574274766),
                new Vector(-99619.46980917, -8715.574274766),
                new Vector(503.0783225363, 44.01365008757),
            },
            // Vector(-1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(-1, 0),
                new Vector(1, 0),
                new Vector(-100000, 0),
                new Vector(505, 0),
            },
            // Vector(1, 0)
            new Vector[]
            {
                new Vector(0, 0),
                new Vector(1, 0),
                new Vector(-1, 0),
                new Vector(100000, 0),
                new Vector(-505, 0),
            },
        };

        public static Vector?[][] Result_DivisionWithDoubleResultVectors { get; } =
        {
            // null
            new Vector?[]{},
            // Vector(1, 0)
            new Vector?[]
            {
                null,
                new Vector(1, 0),
                new Vector(-0.01009183570491, 0),
                new Vector(10, 0),
                new Vector(-100000000, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector?[]
            {
                null,
                new Vector(0.9998476951564, -0.01745240643728),
                new Vector(-0.01009029866946, 0.0001761268184204),
                new Vector(9.998476951564, -0.1745240643728),
                new Vector(-99984769.51564, 1745240.643728),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector?[]
            {
                null,
                new Vector(0.7071067811865, 0.7071067811865),
                new Vector(-0.007136005461565, -0.007136005461565),
                new Vector(7.071067811865, 7.071067811865),
                new Vector(-70710678.11865, -70710678.11865),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector?[]
            {
                null,
                new Vector(0.8660254037844, -0.5),
                new Vector(-0.008739786091275, 0.005045917852457),
                new Vector(8.660254037844, -5),
                new Vector(-86602540.37844, 50000000),
            },
            // Vector(0, 1)
            new Vector?[]
            {
                null,
                new Vector(0, 1),
                new Vector(0, -0.01009183570491),
                new Vector(0, 10),
                new Vector(0, -100000000),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector?[]
            {
                null,
                new Vector(-0.9961946980917, 0.08715574274766),
                new Vector(0.01005343322325, -0.0008795614365492),
                new Vector(-9.961946980917, 0.8715574274766),
                new Vector(99619469.80917, -8715574.274766),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector?[]
            {
                null,
                new Vector(-0.9961946980917, -0.08715574274766),
                new Vector(0.01005343322325, 0.0008795614365492),
                new Vector(-9.961946980917, -0.8715574274766),
                new Vector(99619469.80917, 8715574.274766),
            },
            // Vector(-1, 0)
            new Vector?[]
            {
                null,
                new Vector(-1, 0),
                new Vector(0.01009183570491, 0),
                new Vector(-10, 0),
                new Vector(100000000, 0),
            },
            // Vector(1, 0)
            new Vector?[]
            {
                null,
                new Vector(1, 0),
                new Vector(-0.01009183570491, 0),
                new Vector(10, 0),
                new Vector(-100000000, 0),
            },
        };

        public static Vector?[][] Result_DivisionWithIntegerResultVectors { get; } =
        {
            // null
            new Vector?[]{},
            // Vector(1, 0)
            new Vector?[]
            {
                null,
                new Vector(1, 0),
                new Vector(-1, 0),
                new Vector(1E-5, 0),
                new Vector(-0.001980198019802, 0),
            },
            // Vector(0.9998476951564, -0.01745240643728)
            new Vector?[]
            {
                null,
                new Vector(0.9998476951564, -0.01745240643728),
                new Vector(-0.9998476951564, 0.01745240643728),
                new Vector(9.998476951564E-6, -1.745240643728E-7),
                new Vector(-0.001979896426052, 3.455922066788E-5),
            },
            // Vector(0.7071067811865, 0.7071067811865)
            new Vector?[]
            {
                null,
                new Vector(0.7071067811865, 0.7071067811865),
                new Vector(-0.7071067811865, -0.7071067811865),
                new Vector(7.071067811865E-6, 7.071067811865E-6),
                new Vector(-0.001400211447894, -0.001400211447894),
            },
            // Vector(0.8660254037844, -0.5)
            new Vector?[]
            {
                null,
                new Vector(0.8660254037844, -0.5),
                new Vector(-0.8660254037844, 0.5),
                new Vector(8.660254037844E-6, -5E-6),
                new Vector(-0.001714901789672, 0.000990099009901),
            },
            // Vector(0, 1)
            new Vector?[]
            {
                null,
                new Vector(0, 1),
                new Vector(0, -1),
                new Vector(0, 1E-5),
                new Vector(0, -0.001980198019802),
            },
            // Vector(-0.9961946980917, 0.08715574274766)
            new Vector?[]
            {
                null,
                new Vector(-0.9961946980917, 0.08715574274766),
                new Vector(0.9961946980917, -0.08715574274766),
                new Vector(-9.961946980917E-6, 8.715574274766E-7),
                new Vector(0.001972662768498, -0.0001725856292033),
            },
            // Vector(-0.9961946980917, -0.08715574274766)
            new Vector?[]
            {
                null,
                new Vector(-0.9961946980917, -0.08715574274766),
                new Vector(0.9961946980917, 0.08715574274766),
                new Vector(-9.961946980917E-6, -8.715574274766E-7),
                new Vector(0.001972662768498, 0.0001725856292033),
            },
            // Vector(-1, 0)
            new Vector?[]
            {
                null,
                new Vector(-1, 0),
                new Vector(1, 0),
                new Vector(-1E-5, 0),
                new Vector(0.001980198019802, 0),
            },
            // Vector(1, 0)
            new Vector?[]
            {
                null,
                new Vector(1, 0),
                new Vector(-1, 0),
                new Vector(1E-5, 0),
                new Vector(-0.001980198019802, 0),
            },
        };

        static InputTestData()
        {
            Vectors = new Vector[LineSegments.Length];
            ReversedVectors = new Vector[LineSegments.Length];

            for (int i = 0; i < LineSegments.Length; i++)
            {
                Vectors[i] = new Vector(LineSegments[i].X2 - LineSegments[i].X1, LineSegments[i].Y2 - LineSegments[i].Y1);
                ReversedVectors[i] = new Vector(-Vectors[i].X, -Vectors[i].Y);
            }
        }

        public struct LineSegment
        {
            public double X1 { get; }
            public double Y1 { get; }
            public double X2 { get; }
            public double Y2 { get; }

            public LineSegment(double x1, double y1, double x2, double y2)
            {
                X1 = x1;
                Y1 = y1;
                X2 = x2;
                Y2 = y2;
            }
        }

        public struct LineABCCoefficients
        {
            public double A { get; }
            public double B { get; }
            public double C { get; }

            public LineABCCoefficients(double a, double b, double c)
            {
                A = a;
                B = b;
                C = c;
            }
        }

        public struct Vector
        {
            public double X { get; }
            public double Y { get; }

            public Vector(double x, double y)
            {
                X = x;
                Y = y;
            }
        }

        public struct LengthAndAngle
        {
            public double Length { get; }
            public double Angle { get; }

            public LengthAndAngle(double length, double angle)
            {
                Length = length;
                Angle = angle;
            }
        }
    }
}
