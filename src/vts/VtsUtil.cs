﻿/**
 * Copyright (c) 2017 Melown Technologies SE
 *
 * Redistribution and use in source and binary forms, with or without
 * modification, are permitted provided that the following conditions are met:
 *
 * *  Redistributions of source code must retain the above copyright notice,
 *    this list of conditions and the following disclaimer.
 *
 * *  Redistributions in binary form must reproduce the above copyright
 *    notice, this list of conditions and the following disclaimer in the
 *    documentation and/or other materials provided with the distribution.
 *
 * THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS"
 * AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE
 * ARE DISCLAIMED.  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE
 * LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR
 * CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF
 * SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
 * INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN
 * CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE)
 * ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE
 * POSSIBILITY OF SUCH DAMAGE.
 */

using UnityEngine;
using vts;

public static class VtsUtil
{
    public static Vector3 V2U3(double[] value)
    {
        Util.CheckArray(value, 3);
        Vector3 r = new Vector3();
        for (int i = 0; i < 3; i++)
            r[i] = (float)value[i];
        return r;
    }

    public static Vector3 V2U3(float[] value)
    {
        Util.CheckArray(value, 3);
        Vector3 r = new Vector3();
        for (int i = 0; i < 3; i++)
            r[i] = value[i];
        return r;
    }

    public static double[] U2V3(Vector3 value)
    {
        double[] r = new double[3];
        for (int i = 0; i < 3; i++)
            r[i] = value[i];
        return r;
    }

    public static Vector4 V2U4(double[] value)
    {
        Util.CheckArray(value, 4);
        Vector4 r = new Vector4();
        for (int i = 0; i < 4; i++)
            r[i] = (float)value[i];
        return r;
    }

    public static Vector4 V2U4(float[] value)
    {
        Util.CheckArray(value, 4);
        Vector4 r = new Vector4();
        for (int i = 0; i < 4; i++)
            r[i] = value[i];
        return r;
    }

    public static double[] U2V4(Vector4 value)
    {
        double[] r = new double[4];
        for (int i = 0; i < 4; i++)
            r[i] = value[i];
        return r;
    }

    public static Matrix4x4 V2U44(double[] value)
    {
        Util.CheckArray(value, 16);
        Matrix4x4 r = new Matrix4x4();
        for (int i = 0; i < 16; i++)
            r[i] = (float)value[i];
        return r;
    }

    public static Matrix4x4 V2U44(float[] value)
    {
        Util.CheckArray(value, 16);
        Matrix4x4 r = new Matrix4x4();
        for (int i = 0; i < 16; i++)
            r[i] = value[i];
        return r;
    }

    public static double[] U2V44(Matrix4x4 value)
    {
        double[] r = new double[16];
        for (int i = 0; i < 16; i++)
            r[i] = value[i];
        return r;
    }

    // unity does not have Matrix3x3, so we use Matrix4x4 to pass the matrix to shader and the shader then converts it
    public static Matrix4x4 V2U33(float[] value)
    {
        Util.CheckArray(value, 9);
        Matrix4x4 r = new Matrix4x4();
        r[0] = value[0];
        r[1] = value[1];
        r[2] = value[2];
        r[3] = 0;
        r[4] = value[3];
        r[5] = value[4];
        r[6] = value[5];
        r[7] = 0;
        r[8] = value[6];
        r[9] = value[7];
        r[10] = value[8];
        r[11] = 0;
        r[12] = 0;
        r[13] = 0;
        r[14] = 0;
        r[15] = 1;
        return r;
    }
}
