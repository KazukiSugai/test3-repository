<?xml version="1.0" encoding="UTF-8"?>
<flexsim-tree version="4" treetype="userlibrary">
<node f="43" dt="4"><name>UserLibrary 1</name><data>
 <node f="40"><name></name></node>
 <node f="42" dt="2"><name>release</name><data>23.0</data></node>
 <node f="42" dt="1"><name>picturealignleft</name><data>0000000040360000</data></node>
</data>
 <node f="40"><name></name></node>
 <node f="42" dt="4"><name>プロセッサ1</name><data>
  <node f="40"><name></name></node>
  <node f="42"><name>classes</name>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>Processor</name><data><coupling>null</coupling></data></node>
  </node>
  <node f="42"><name>superclasses</name>
   <node f="40"><name></name></node>
   <node f="42" dt="3"><name>FixedResource</name><data><coupling>null</coupling></data></node>
  </node>
  <node f="42"><name>variables</name>
   <node f="80000040"><name></name></node>
   <node f="42" dt="1"><name>cycletime</name><data>0000000040240000</data></node>
   <node f="42" dt="1"><name>setuptime</name><data>0000000000000000</data>
    <node f="40"><name></name></node></node>
   <node f="42" dt="1"><name>maxcontent</name><data>000000003ff00000</data>
    <node f="40"><name></name></node></node>
   <node f="42" dt="1"><name>useprocessoperators</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>usesetupoperators</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>nrofprocessoperators</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>processoperatorpriority</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>preemptprocessoperators</name><data>0000000000000000</data></node>
   <node f="442" dt="2"><name>processdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int trigger = param(2);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data></node>
   <node f="42" dt="1"><name>convey</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>usesameop</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>nrofsetupoperators</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>nrreleased</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>pull</name><data>0000000000000000</data></node>
   <node f="8000000442" dt="2"><name>sendtoport</name><data>Object item = param(1);
Object current = ownerobject(c);
/**最初に利用可能*/

return 0 ;</data>
    <node f="40"><name></name></node></node>
   <node f="8000000442" dt="2"><name>receivefromport</name><data>Object current = ownerobject(c);
/**任意のﾎﾟｰﾄ*/
return 0;
</data>
    <node f="40"><name></name></node></node>
   <node f="8000000442" dt="2"><name>pullrequirement</name><data>Object current = ownerobject(c);
Object item = param(1);
int port =  param(2);

/**何でもプル*/

return 1;</data>
    <node f="40"><name></name></node></node>
   <node f="42" dt="1"><name>usetransport</name><data>0000000000000000</data>
    <node f="40"><name></name></node></node>
   <node f="42" dt="1"><name>transportpriority</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>preempttransport</name><data>0000000000000000</data></node>
   <node f="442" dt="2"><name>transportdispatcher</name><data>Object current = ownerobject(c);
Object item = param(1);
int port = param(2);
Object destination = param(3);
double priority = param(4);
int preempt = param(5);

/***popup:CenterObject*/
return /**/current.centerObjects[/**/
	/***tag:portnr*//**/1/**//**/]/**/;
</data>
    <node f="40"><name></name></node></node>
   <node f="42" dt="1"><name>nroftransportsout</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>nroftransportsin</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>outwaitinfo</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>sendtocontinuous</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>pullcontinuous</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>lifo</name><data>0000000000000000</data></node>
   <node f="42"><name>timetables</name></node>
   <node f="42"><name>networknodes</name></node>
   <node f="42" dt="1"><name>timeoflaststop</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>nrofstops</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>statebeforestop</name><data>0000000000000000</data></node>
   <node f="42"><name>collisionspheres</name></node>
   <node f="42"><name>collisionobjects</name></node>
   <node f="42" dt="1"><name>savedstate</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>resetposition</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>doanimations</name><data>000000003ff00000</data></node>
  </node>
  <node f="42"><name>behaviour</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>stats</name>
   <node f="40"><name></name></node>
   <node f="42" dt="7"><name>state_current</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="6"><name>profile</name><data f="1">
     <fields>
      <field name="state" bytesize="36" type="259"/>
      <field name="time" bytesize="8" type="1"/>
      <field name="active" bytesize="4" type="2"/>
     </fields>
     <entry><ed>other</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>idle</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>processing</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>busy</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>blocked</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>generating</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>collecting</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>releasing</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>waiting for operator</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>waiting for transport</ed><ed>0000000000000000</ed><ed>1</ed></entry>
     <entry><ed>breakdown</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>scheduled down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>conveying</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>travel empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>travel loaded</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>offset travel empty</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>offset travel loaded</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>loading</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>unloading</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>down</ed><ed>0000000000000000</ed><ed>0</ed></entry>
     <entry><ed>setup</ed><ed>0000000000000000</ed><ed>1</ed></entry></data></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040100000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000040350000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>cumulative</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>cumulativeTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>minValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>maxValue</name><data>0000000040350000</data></node>
     <node f="42" dt="1"><name>numEntries</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>lastSetTime</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>rate</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>lastResetTime</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="7"><name>stats_input</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="7"><name>stats_output</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040000000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="7"><name>stats_content</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>000000003ff00000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="7"><name>stats_staytime</name><data/>
    <node f="40"><name></name></node>
    <node f="42" dt="2"><name>sdt::attributetree</name><data>TrackedVariable</data>
     <node f="40"><name></name></node>
     <node f="42" dt="1"><name>type</name><data>0000000040080000</data></node>
     <node f="42" dt="1"><name>flags</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>curValue</name><data>0000000000000000</data></node>
     <node f="42" dt="1"><name>startValue</name><data>0000000000000000</data></node>
    </node>
   </node>
   <node f="42" dt="1"><name>stats_creationtime</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>stats_lastmovetime</name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>visual</name>
   <node f="40"><name></name></node>
   <node f="42"><name>color</name>
    <node f="40"><name></name></node>
    <node f="42" dt="1"><name>red</name><data>851eb8523fd851eb</data></node>
    <node f="42" dt="1"><name>green</name><data>333333333fe73333</data></node>
    <node f="42" dt="1"><name>blue</name><data>ac0831273fd45a1c</data></node>
   </node>
   <node f="42" dt="2"><name>shape</name><data>fs3d\Processor\Processor.3ds</data></node>
   <node f="42" dt="1"><name>shapeindex</name><data>0000000000000000</data></node>
   <node f="42" dt="2"><name>picture</name><data>bitmaps\processorpicturesmall.png</data></node>
   <node f="42" dt="2"><name>imageobject</name><data>***</data></node>
   <node f="42" dt="1"><name>imageindexobject</name><data>0000000000000000</data></node>
   <node f="42" dt="2"><name>imagebase</name><data>***</data></node>
   <node f="42" dt="1"><name>imageindexbase</name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>special</name>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>title</name><data>Fixed Resource Multiservice</data></node>
   <node f="42" dt="2"><name>description</name><data></data></node>
   <node f="42" dt="2"><name>guifocusclass</name><data>VIEW:/standardviews/modelingutilities/QuickerProperties</data></node>
   <node f="4000000042" dt="2"><name>tooltip</name><data>ﾌﾛｰｱｲﾃﾑを処理します</data></node>
  </node>
  <node f="42"><name>spatial</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>spatialx</name><data>00000000c0a77000</data></node>
   <node f="42" dt="1"><name>spatialy</name><data>0000000040b77000</data></node>
   <node f="42" dt="1"><name>spatialz</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>spatialsx</name><data>0000000040af4000</data></node>
   <node f="42" dt="1"><name>spatialsy</name><data>cec0000040a77002</data></node>
   <node f="42" dt="1"><name>spatialsz</name><data>0c000000409f3ffe</data></node>
   <node f="42" dt="1"><name>spatialrx</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>spatialry</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>spatialrz</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>centroid</name><data>000000003ff00000</data></node>
   <node f="42" dt="1"><name>offsetx</name><data>000000003fe00000</data></node>
   <node f="42" dt="1"><name>offsety</name><data>c00000003fe01805</data></node>
   <node f="42" dt="1"><name>offsetz</name><data>a0000000bf7af6c1</data></node>
   <node f="42" dt="1"><name>offsetsx</name><data>e00000003fcfffff</data></node>
   <node f="42" dt="1"><name>offsetsy</name><data>c00000003fd55552</data></node>
   <node f="42" dt="1"><name>offsetsz</name><data>000000003fe00001</data></node>
   <node f="42" dt="1"><name>offsetrx</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>offsetry</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>offsetrz</name><data>0000000000000000</data></node>
  </node>
  <node f="42"><name>objectinfo</name>
   <node f="40"><name></name></node>
   <node f="42" dt="1"><name>Output: 0</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>%Idle:  0.0</name><data>0000000000000000</data></node>
   <node f="42" dt="1"><name>%Processing: 0.0</name><data>0000000000000000</data></node>
  </node>
  <node f="4000000042" dt="2"><name>windowtitle</name><data>プロセッサ1</data>
   <node f="40"><name></name></node></node>
  <node f="42"><name>labels</name>
   <node f="40"><name></name></node></node>
  <node f="42"><name>connections</name>
   <node f="40"><name></name></node>
   <node f="42"><name>connectionsin</name>
    <node f="40"><name></name></node></node>
   <node f="42"><name>connectionsout</name>
    <node f="40"><name></name></node></node>
   <node f="42"><name>connectionscenter</name>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42"><name>events</name>
   <node f="40"><name></name></node></node>
  <node f="42" dt="7"><name>resetvalues</name><data/>
   <node f="40"><name></name></node>
   <node f="42" dt="2"><name>sdt::attributetree</name><data>ObjectResetValues</data>
    <node f="40"><name></name></node></node>
  </node>
  <node f="42"><name>stored</name></node>
 </data></node>
</node></flexsim-tree>
