(window.webpackJsonp=window.webpackJsonp||[]).push([[7],{345:function(t,e,r){"use strict";r.d(e,"a",(function(){return o})),r.d(e,"b",(function(){return d})),r.d(e,"c",(function(){return l})),r.d(e,"d",(function(){return v}));var n=r(347),c=r(2),o=Object(c.g)("v-card__actions"),d=Object(c.g)("v-card__subtitle"),l=Object(c.g)("v-card__text"),v=Object(c.g)("v-card__title");n.a},364:function(t,e,r){"use strict";r.r(e);var n=r(5),c=(r(53),{computed:{sanatoriums:{get:function(){return this.$store.state.sanatoriums},set:function(t){this.$store.commit("SET_SANATORIUMS",t)}}},fetch:function(){var t=this;return Object(n.a)(regeneratorRuntime.mark((function e(){return regeneratorRuntime.wrap((function(e){for(;;)switch(e.prev=e.next){case 0:return e.next=2,t.$store.dispatch("fetchSanatoriums");case 2:case"end":return e.stop()}}),e)})))()}}),o=r(81),d=r(105),l=r.n(d),v=r(350),_=r(347),m=r(345),f=r(242),h=r(86),component=Object(o.a)(c,(function(){var t=this,e=t.$createElement,r=t._self._c||e;return r("v-sheet",{staticClass:"d-flex flex-wrap pt-8 pr-4 pl-4",attrs:{color:"white",elevation:"1"}},t._l(t.sanatoriums,(function(e){return r("v-card",{key:e.id,staticClass:"mx-auto mr-8 ml-8 mb-8",attrs:{width:"412"}},[r("v-img",{staticClass:"white--text align-end",attrs:{height:"200px",src:"http://localhost:5000"+e.imageLink[0]}},[r("v-card-title",[t._v(t._s(e.name))])],1),t._v(" "),r("v-card-subtitle",{staticClass:"pb-0"},[t._v("\n          "+t._s(e.contacts.phone)+"\n        ")]),t._v(" "),r("v-card-text",{staticClass:"text--primary"},[t._v(t._s(e.contacts.address))]),t._v(" "),r("v-card-actions",[r("v-btn",{attrs:{color:"accent",text:"",exact:"",to:"/sanatorium/"+e.id}},[t._v("Подробно")])],1)],1)})),1)}),[],!1,null,null,null);e.default=component.exports;l()(component,{VBtn:v.a,VCard:_.a,VCardActions:m.a,VCardSubtitle:m.b,VCardText:m.c,VCardTitle:m.d,VImg:f.a,VSheet:h.a})}}]);