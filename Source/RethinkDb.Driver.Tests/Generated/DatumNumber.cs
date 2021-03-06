




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591 // Missing XML comment for publicly visible type or member
#pragma warning disable 219 //The variable 'lower_limit' is assigned but its value is never used
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;
using static RethinkDb.Driver.Tests.TestingCommon;

namespace RethinkDb.Driver.Test.Generated {

    // Tests of conversion to and from the RQL number type

    [TestFixture]
    public class DatumNumber : YamlTestFixture {

        public DatumNumber (){
        }




        [Test]
        public void YamlTest_DatumNumber(){

             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiNiIsIk9yaWdpbmFsIjoici5leHByKDEpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiIxIiwiRXhwZWN0ZWRUeXBlIjoibG9uZyIsIkV4cGVjdGVkSmF2YSI6IjFMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #6
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1) */
                 var obtained = runOrCatch( r.expr(1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTUiLCJPcmlnaW5hbCI6InIuZXhwcigtMSkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoLTFMKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiItMSIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiItMUwiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/number.yaml, #15
                 /* ExpectedOriginal: -1 */
                 var expected_ = -1L;
                 
                 /* Original: r.expr(-1) */
                 var obtained = runOrCatch( r.expr(-1L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMjQiLCJPcmlnaW5hbCI6InIuZXhwcigwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigwTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMCIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIwTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #24
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: r.expr(0) */
                 var obtained = runOrCatch( r.expr(0L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMzUiLCJPcmlnaW5hbCI6InIuZXhwcigxLjApIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDEuMCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMS4wIiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiMS4wIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #35
                 /* ExpectedOriginal: 1.0 */
                 var expected_ = 1.0;
                 
                 /* Original: r.expr(1.0) */
                 var obtained = runOrCatch( r.expr(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiNDQiLCJPcmlnaW5hbCI6InIuZXhwcigxLjUpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDEuNSkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMS41IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiMS41IiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #44
                 /* ExpectedOriginal: 1.5 */
                 var expected_ = 1.5;
                 
                 /* Original: r.expr(1.5) */
                 var obtained = runOrCatch( r.expr(1.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiNTMiLCJPcmlnaW5hbCI6InIuZXhwcigtMC41KSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigtMC41KSIsIkV4cGVjdGVkT3JpZ2luYWwiOiItMC41IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiLTAuNSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #53
                 /* ExpectedOriginal: -0.5 */
                 var expected_ = -0.5;
                 
                 /* Original: r.expr(-0.5) */
                 var obtained = runOrCatch( r.expr(-0.5) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiNjIiLCJPcmlnaW5hbCI6InIuZXhwcig2NzQ5OC44OTI3OCkiLCJWYXJOYW1lIjpudWxsLCJWYXJUeXBlIjpudWxsLCJSdW5JZlF1ZXJ5IjpmYWxzZSwiVmFsdWUiOm51bGwsIkphdmEiOiJyLmV4cHIoNjc0OTguODkyNzgpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6IjY3NDk4Ljg5Mjc4IiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiNjc0OTguODkyNzgiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/number.yaml, #62
                 /* ExpectedOriginal: 67498.89278 */
                 var expected_ = 67498.89278;
                 
                 /* Original: r.expr(67498.89278) */
                 var obtained = runOrCatch( r.expr(67498.89278) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiNzMiLCJPcmlnaW5hbCI6InIuZXhwcigxMjM0NTY3ODkwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxMjM0NTY3ODkwTCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMTIzNDU2Nzg5MCIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIxMjM0NTY3ODkwTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #73
                 /* ExpectedOriginal: 1234567890 */
                 var expected_ = 1234567890L;
                 
                 /* Original: r.expr(1234567890) */
                 var obtained = runOrCatch( r.expr(1234567890L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiODMiLCJPcmlnaW5hbCI6InIuZXhwcigtNzM4NTAzODAxMjI0MjMpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKC03Mzg1MDM4MDEyMjQyM0wpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6Ii03Mzg1MDM4MDEyMjQyMyIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiItNzM4NTAzODAxMjI0MjNMIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #83
                 /* ExpectedOriginal: -73850380122423 */
                 var expected_ = -73850380122423L;
                 
                 /* Original: r.expr(-73850380122423) */
                 var obtained = runOrCatch( r.expr(-73850380122423L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiOTUiLCJPcmlnaW5hbCI6InIuZXhwcigxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTAxMjM0NTY3ODkwKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTAxMjM0NTY3ODkwLjApIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImZsb2F0KDEyMzQ1Njc4OTAxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTApIiwiRXhwZWN0ZWRUeXBlIjoiZG91YmxlIiwiRXhwZWN0ZWRKYXZhIjoiZmxvYXRfKDEyMzQ1Njc4OTAxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTAuMCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/number.yaml, #95
                 /* ExpectedOriginal: float(1234567890123456789012345678901234567890) */
                 var expected_ = float_(1234567890123456789012345678901234567890.0);
                 
                 /* Original: r.expr(1234567890123456789012345678901234567890) */
                 var obtained = runOrCatch( r.expr(1234567890123456789012345678901234567890.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTAwIiwiT3JpZ2luYWwiOiJyLmV4cHIoMTIzLjQ1Njc4OTAxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTApIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDEyMy40NTY3ODkwMTIzNDU2OCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMTIzLjQ1Njc4OTAxMjM0NTY3ODkwMTIzNDU2Nzg5MDEyMzQ1Njc4OTAiLCJFeHBlY3RlZFR5cGUiOiJkb3VibGUiLCJFeHBlY3RlZEphdmEiOiIxMjMuNDU2Nzg5MDEyMzQ1NjgiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/number.yaml, #100
                 /* ExpectedOriginal: 123.4567890123456789012345678901234567890 */
                 var expected_ = 123.45678901234568;
                 
                 /* Original: r.expr(123.4567890123456789012345678901234567890) */
                 var obtained = runOrCatch( r.expr(123.45678901234568) ,
                                            new {
                    }, conn);
                 
                     assertEquals((double) expected_, (double) obtained, 0.00000000001);
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTAzIiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkudHlwZV9vZigpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDFMKS50eXBlT2YoKSIsIkV4cGVjdGVkT3JpZ2luYWwiOiJOVU1CRVIiLCJFeHBlY3RlZFR5cGUiOiJTdHJpbmciLCJFeHBlY3RlZEphdmEiOiJcIk5VTUJFUlwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #103
                 /* ExpectedOriginal: NUMBER */
                 var expected_ = "NUMBER";
                 
                 /* Original: r.expr(1).type_of() */
                 var obtained = runOrCatch( r.expr(1L).typeOf() ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTA3IiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkuY29lcmNlX3RvKCdzdHJpbmcnKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuY29lcmNlVG8oXCJzdHJpbmdcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMSIsIkV4cGVjdGVkVHlwZSI6IlN0cmluZyIsIkV4cGVjdGVkSmF2YSI6IlwiMVwiIiwiT2J0YWluZWQiOm51bGwsIlJ1bk9wdHMiOltdLCJSZW5kZXJTb21ldGhpbmciOmZhbHNlfQ==" );
                 //JavaQuery, datum/number.yaml, #107
                 /* ExpectedOriginal: 1 */
                 var expected_ = "1";
                 
                 /* Original: r.expr(1).coerce_to('string') */
                 var obtained = runOrCatch( r.expr(1L).coerceTo("string") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTEwIiwiT3JpZ2luYWwiOiJyLmV4cHIoMSkuY29lcmNlX3RvKCdudW1iZXInKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxTCkuY29lcmNlVG8oXCJudW1iZXJcIikiLCJFeHBlY3RlZE9yaWdpbmFsIjoiMSIsIkV4cGVjdGVkVHlwZSI6ImxvbmciLCJFeHBlY3RlZEphdmEiOiIxTCIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #110
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: r.expr(1).coerce_to('number') */
                 var obtained = runOrCatch( r.expr(1L).coerceTo("number") ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTE1IiwiT3JpZ2luYWwiOiJyLmV4cHIoMS4wKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxLjApIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImludF9jbXAoMSkiLCJFeHBlY3RlZFR5cGUiOiJJbnRDbXAiLCJFeHBlY3RlZEphdmEiOiJpbnRfY21wKDFMKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #115
                 /* ExpectedOriginal: int_cmp(1) */
                 var expected_ = int_cmp(1L);
                 
                 /* Original: r.expr(1.0) */
                 var obtained = runOrCatch( r.expr(1.0) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTE5IiwiT3JpZ2luYWwiOiJyLmV4cHIoNDUpIiwiVmFyTmFtZSI6bnVsbCwiVmFyVHlwZSI6bnVsbCwiUnVuSWZRdWVyeSI6ZmFsc2UsIlZhbHVlIjpudWxsLCJKYXZhIjoici5leHByKDQ1TCkiLCJFeHBlY3RlZE9yaWdpbmFsIjoiaW50X2NtcCg0NSkiLCJFeHBlY3RlZFR5cGUiOiJJbnRDbXAiLCJFeHBlY3RlZEphdmEiOiJpbnRfY21wKDQ1TCkiLCJPYnRhaW5lZCI6bnVsbCwiUnVuT3B0cyI6W10sIlJlbmRlclNvbWV0aGluZyI6ZmFsc2V9" );
                 //JavaQuery, datum/number.yaml, #119
                 /* ExpectedOriginal: int_cmp(45) */
                 var expected_ = int_cmp(45L);
                 
                 /* Original: r.expr(45) */
                 var obtained = runOrCatch( r.expr(45L) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             
             {
                 SetContext( "eyJUZXN0VHlwZSI6IkphdmFRdWVyeSIsIlRlc3RGaWxlIjoiZGF0dW0vbnVtYmVyLnlhbWwiLCJMaW5lTnVtIjoiMTIzIiwiT3JpZ2luYWwiOiJyLmV4cHIoMS4yKSIsIlZhck5hbWUiOm51bGwsIlZhclR5cGUiOm51bGwsIlJ1bklmUXVlcnkiOmZhbHNlLCJWYWx1ZSI6bnVsbCwiSmF2YSI6InIuZXhwcigxLjIpIiwiRXhwZWN0ZWRPcmlnaW5hbCI6ImZsb2F0X2NtcCgxLjIpIiwiRXhwZWN0ZWRUeXBlIjoiRmxvYXRDbXAiLCJFeHBlY3RlZEphdmEiOiJmbG9hdF9jbXAoMS4yKSIsIk9idGFpbmVkIjpudWxsLCJSdW5PcHRzIjpbXSwiUmVuZGVyU29tZXRoaW5nIjpmYWxzZX0=" );
                 //JavaQuery, datum/number.yaml, #123
                 /* ExpectedOriginal: float_cmp(1.2) */
                 var expected_ = float_cmp(1.2);
                 
                 /* Original: r.expr(1.2) */
                 var obtained = runOrCatch( r.expr(1.2) ,
                                            new {
                    }, conn);
                 
                     assertEquals(expected_, obtained);                 
             }
             

        }
    }
}
