




//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Ast;
using NUnit.Framework;
using RethinkDb.Driver.Tests;

namespace RethinkDb.Driver.Test.Generated {
    [TestFixture]
    public class GeoIndexing : GeneratedTest {

            public static Table tbl = r.db(DbName).table("tbl");


        [Test]
        public void YamlTest(){

             
             //JavaDef, geo/indexing.yaml, #Templates.YamlTest+DefTest.
             //Original: rows = [{'id':0, 'g':r.point(10,10), 'm':[r.point(0,0),r.point(1,0),r.point(2,0)]}, {'id':1, 'g':r.polygon([0,0], [0,1], [1,1], [1,0])}, {'id':2, 'g':r.line([0.000002,-1], [-0.000001,1])}]
             
var rows = (IList) (r.array(r.hashMap("id", 0L).with("g", r.point(10L, 10L)).with("m", r.array(r.point(0L, 0L), r.point(1L, 0L), r.point(2L, 0L))), r.hashMap("id", 1L).with("g", r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 1L), r.array(1L, 0L))), r.hashMap("id", 2L).with("g", r.line(r.array(2e-06, -1L), r.array(-1e-06, 1L)))));             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #2
                 /* ExpectedOriginal: ({'deleted':0,'inserted':3,'skipped':0,'errors':0,'replaced':0,'unchanged':0}) */
                 var expected_ = r.hashMap("deleted", 0L).with("inserted", 3L).with("skipped", 0L).with("errors", 0L).with("replaced", 0L).with("unchanged", 0L);
                 
                 /* Original: tbl.insert(rows) */
                 var obtained = runOrCatch( tbl.insert(rows) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #3
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('g', geo=true) */
                 var obtained = runOrCatch( tbl.indexCreate("g").optArg("geo", true) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #4
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('m', geo=true, multi=true) */
                 var obtained = runOrCatch( tbl.indexCreate("m").optArg("geo", true).optArg("multi", true) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #5
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('other') */
                 var obtained = runOrCatch( tbl.indexCreate("other") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #6
                 /* ExpectedOriginal: ({'created':1}) */
                 var expected_ = r.hashMap("created", 1L);
                 
                 /* Original: tbl.index_create('point_det', lambda x: r.point(x, x) ) */
                 var obtained = runOrCatch( tbl.indexCreate("point_det", x => r.point(x, x)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #7
                 /* ExpectedOriginal: None */
                 var expected_ = null as object;
                 
                 /* Original: tbl.index_wait() */
                 var obtained = runOrCatch( tbl.indexWait() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #8
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Index `other` is not a geospatial index.  get_intersecting can only be used with a geospatial index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Index `other` is not a geospatial index.  get_intersecting can only be used with a geospatial index.", r.array(0L));
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='other').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "other").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #9
                 /* ExpectedOriginal: err_regex('ReqlOpFailedError', 'Index `missing` was not found on table `[a-zA-Z0-9_]+.[a-zA-Z0-9_]+`[.]', [0]) */
                 var expected_ = err_regex("ReqlOpFailedError", "Index `missing` was not found on table `[a-zA-Z0-9_]+.[a-zA-Z0-9_]+`[.]", r.array(0L));
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='missing').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "missing").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #10
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'get_intersecting requires an index argument.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "get_intersecting requires an index argument.", r.array(0L));
                 
                 /* Original: tbl.get_intersecting(r.point(0,0)).count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #11
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.", r.array(0L));
                 
                 /* Original: tbl.get_all(0, index='g').count() */
                 var obtained = runOrCatch( tbl.getAll(0L).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #12
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.", r.array(0L));
                 
                 /* Original: tbl.between(0, 1, index='g').count() */
                 var obtained = runOrCatch( tbl.between(0L, 1L).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #13
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Index `g` is a geospatial index.  Only get_nearest and get_intersecting can use a geospatial index.", r.array(0L));
                 
                 /* Original: tbl.order_by(index='g').count() */
                 var obtained = runOrCatch( tbl.orderBy().optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #17
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'get_intersecting cannot use the primary index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "get_intersecting cannot use the primary index.", r.array(0L));
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='id').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "id").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #18
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #19
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(10,10), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(10L, 10L)).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #20
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(0.5,0.5), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0.5, 0.5)).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #21
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.get_intersecting(r.point(20,20), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(20L, 20L)).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #22
                 /* ExpectedOriginal: 2 */
                 var expected_ = 2L;
                 
                 /* Original: tbl.get_intersecting(r.polygon([0,0], [1,0], [1,1], [0,1]), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.polygon(r.array(0L, 0L), r.array(1L, 0L), r.array(1L, 1L), r.array(0L, 1L))).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #23
                 /* ExpectedOriginal: 3 */
                 var expected_ = 3L;
                 
                 /* Original: tbl.get_intersecting(r.line([0,0], [10,10]), index='g').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.line(r.array(0L, 0L), r.array(10L, 10L))).optArg("index", "g").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #24
                 /* ExpectedOriginal: ("SELECTION<STREAM>") */
                 var expected_ = "SELECTION<STREAM>";
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='g').type_of() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "g").typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #25
                 /* ExpectedOriginal: ("SELECTION<STREAM>") */
                 var expected_ = "SELECTION<STREAM>";
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='g').filter(true).type_of() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "g").filter(true).typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #27
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(0,0), index='m').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(0L, 0L)).optArg("index", "m").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #28
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(1,0), index='m').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(1L, 0L)).optArg("index", "m").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #29
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.point(2,0), index='m').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(2L, 0L)).optArg("index", "m").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #30
                 /* ExpectedOriginal: 0 */
                 var expected_ = 0L;
                 
                 /* Original: tbl.get_intersecting(r.point(3,0), index='m').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.point(3L, 0L)).optArg("index", "m").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #31
                 /* ExpectedOriginal: 1 */
                 var expected_ = 1L;
                 
                 /* Original: tbl.get_intersecting(r.polygon([0,0], [0,1], [1,1], [1,0]), index='m').count() */
                 var obtained = runOrCatch( tbl.getIntersecting(r.polygon(r.array(0L, 0L), r.array(0L, 1L), r.array(1L, 1L), r.array(1L, 0L))).optArg("index", "m").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #32
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'Index `other` is not a geospatial index.  get_nearest can only be used with a geospatial index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "Index `other` is not a geospatial index.  get_nearest can only be used with a geospatial index.", r.array(0L));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='other') */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "other") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #33
                 /* ExpectedOriginal: err_regex('ReqlOpFailedError', 'Index `missing` was not found on table `[a-zA-Z0-9_]+.[a-zA-Z0-9_]+`[.]', [0]) */
                 var expected_ = err_regex("ReqlOpFailedError", "Index `missing` was not found on table `[a-zA-Z0-9_]+.[a-zA-Z0-9_]+`[.]", r.array(0L));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='missing') */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "missing") ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #34
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'get_nearest requires an index argument.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "get_nearest requires an index argument.", r.array(0L));
                 
                 /* Original: tbl.get_nearest(r.point(0,0)) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #38
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'get_nearest cannot use the primary index.', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "get_nearest cannot use the primary index.", r.array(0L));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='id').count() */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "id").count() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #39
                 /* ExpectedOriginal: ([{'dist':0,'doc':{'id':1}},{'dist':0.055659745396754216,'doc':{'id':2}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 1L)), r.hashMap("dist", 0.055659745396754216).with("doc", r.hashMap("id", 2L)));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g').pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #40
                 /* ExpectedOriginal: ([{'dist':0,'doc':{'id':2}},{'dist':0.11130264976984369,'doc':{'id':1}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 2L)), r.hashMap("dist", 0.11130264976984369).with("doc", r.hashMap("id", 1L)));
                 
                 /* Original: tbl.get_nearest(r.point(-0.000001,1), index='g').pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(-1e-06, 1L)).optArg("index", "g").pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #41
                 /* ExpectedOriginal: ([{'dist':0,'doc':{'id':1}},{'dist':0.055659745396754216,'doc':{'id':2}},{'dist':1565109.0992178896,'doc':{'id':0}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 1L)), r.hashMap("dist", 0.055659745396754216).with("doc", r.hashMap("id", 2L)), r.hashMap("dist", 1565109.0992178896).with("doc", r.hashMap("id", 0L)));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g', max_dist=1565110).pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").optArg("max_dist", 1565110L).pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #42
                 /* ExpectedOriginal: ([{'dist':0,'doc':{'id':1}},{'dist':0.055659745396754216,'doc':{'id':2}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 1L)), r.hashMap("dist", 0.055659745396754216).with("doc", r.hashMap("id", 2L)));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g', max_dist=1565110, max_results=2).pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").optArg("max_dist", 1565110L).optArg("max_results", 2L).pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #43
                 /* ExpectedOriginal: err('ReqlQueryLogicError', 'The distance has become too large for continuing the indexed nearest traversal.  Consider specifying a smaller `max_dist` parameter.  (Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 10968937.995244588703m, but must be smaller than 9985163.1855612862855m.)', [0]) */
                 var expected_ = err("ReqlQueryLogicError", "The distance has become too large for continuing the indexed nearest traversal.  Consider specifying a smaller `max_dist` parameter.  (Radius must be smaller than a quarter of the circumference along the minor axis of the reference ellipsoid.  Got 10968937.995244588703m, but must be smaller than 9985163.1855612862855m.)", r.array(0L));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g', max_dist=10000000).pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").optArg("max_dist", 10000000L).pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #44
                 /* ExpectedOriginal: ([{'dist':0,'doc':{'id':1}},{'dist':0.00005565974539675422,'doc':{'id':2}},{'dist':1565.1090992178897,'doc':{'id':0}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 1L)), r.hashMap("dist", 5.565974539675422e-05).with("doc", r.hashMap("id", 2L)), r.hashMap("dist", 1565.1090992178897).with("doc", r.hashMap("id", 0L)));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g', max_dist=1566, unit='km').pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").optArg("max_dist", 1566L).optArg("unit", "km").pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #45
                 /* ExpectedOriginal: ([{'dist':0, 'doc':{'id':1}}, {'dist':8.726646259990191e-09, 'doc':{'id':2}}, {'dist':0.24619691677893205, 'doc':{'id':0}}]) */
                 var expected_ = r.array(r.hashMap("dist", 0L).with("doc", r.hashMap("id", 1L)), r.hashMap("dist", 8.726646259990191e-09).with("doc", r.hashMap("id", 2L)), r.hashMap("dist", 0.24619691677893205).with("doc", r.hashMap("id", 0L)));
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g', max_dist=1, geo_system='unit_sphere').pluck('dist', {'doc':'id'}) */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").optArg("max_dist", 1L).optArg("geo_system", "unit_sphere").pluck("dist", r.hashMap("doc", "id")) ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             
             TestCounter++;
             
             {
                 //JavaQuery, geo/indexing.yaml, #46
                 /* ExpectedOriginal: ("ARRAY") */
                 var expected_ = "ARRAY";
                 
                 /* Original: tbl.get_nearest(r.point(0,0), index='g').type_of() */
                 var obtained = runOrCatch( tbl.getNearest(r.point(0L, 0L)).optArg("index", "g").typeOf() ,
                                            new OptArgs()
                    );
                 assertEquals(expected_, obtained);
             }
             

        }
    }
}