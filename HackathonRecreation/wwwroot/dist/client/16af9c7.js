(window.webpackJsonp=window.webpackJsonp||[]).push([[8],{379:function(e,t,r){"use strict";r.r(t);var n=r(5),o=(r(53),{data:function(){return{showPass:!1,showVerifyPass:!1,valid:!1,registerData:{firstName:"",lastName:"",middleName:"",email:"",password:"",phone:""},verifyPassword:"",rules:{required:function(e){return!!e||"Обязательно"},min2:function(e){return e&&e.length>=2||"Не менее двух символов"},password:[function(e){return!!e||"Пароль обязателен"},function(e){return e&&e.length<=15||"Пароль должен быть менее 15 символов"},function(e){return e&&e.length>=8||"Пароль должен быть более 8 символов"}],email:[function(e){return!!e||"Электронная почта обязательна"},function(e){return/^(([^<>()[\]\\.,;:\s@"]+(\.[^<>()[\]\\.,;:\s@"]+)*)|(".+"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/.test(e)||"Электронная почта не валидна"}]}}},computed:{passwordMatch:function(){var e=this;return function(){return e.registerData.password===e.verifyPassword||"Пароли не совпадают"}}},methods:{register:function(){var e=this;return Object(n.a)(regeneratorRuntime.mark((function t(){return regeneratorRuntime.wrap((function(t){for(;;)switch(t.prev=t.next){case 0:if(!e.$refs.registerForm.validate()){t.next=11;break}return t.next=3,e.$store.dispatch("register",{firstName:e.registerData.firstName,lastName:e.registerData.lastName,middleName:e.registerData.middleName,email:e.registerData.email,password:e.registerData.password,phone:e.registerData.phone});case 3:e.registerData.firstName="",e.registerData.lastName="",e.registerData.middleName="",e.registerData.email="",e.registerData.password="",e.verifyPassword="",e.registerData.phone="",e.$router.push("/sanatorium");case 11:case"end":return t.stop()}}),t)})))()}}}),l=r(81),c=r(105),d=r.n(c),f=r(350),m=r(356),h=r(381),v=r(357),w=r(446),component=Object(l.a)(o,(function(){var e=this,t=e.$createElement,r=e._self._c||t;return r("v-form",{ref:"registerForm",attrs:{"lazy-validation":""},model:{value:e.valid,callback:function(t){e.valid=t},expression:"valid"}},[r("v-row",[r("v-col",{attrs:{cols:"12",md:"4"}},[r("v-text-field",{attrs:{rules:[e.rules.min2],label:"Фамилия",required:""},model:{value:e.registerData.lastName,callback:function(t){e.$set(e.registerData,"lastName",t)},expression:"registerData.lastName"}})],1),e._v(" "),r("v-col",{attrs:{cols:"12",md:"4"}},[r("v-text-field",{attrs:{rules:[e.rules.min2],label:"Имя",required:""},model:{value:e.registerData.firstName,callback:function(t){e.$set(e.registerData,"firstName",t)},expression:"registerData.firstName"}})],1),e._v(" "),r("v-col",{attrs:{cols:"12",md:"4"}},[r("v-text-field",{attrs:{label:"Отчество"},model:{value:e.registerData.middleName,callback:function(t){e.$set(e.registerData,"middleName",t)},expression:"registerData.middleName"}})],1)],1),e._v(" "),r("v-row",[r("v-col",{attrs:{cols:"12",md:"6"}},[r("v-text-field",{attrs:{rules:e.rules.email,label:"Электронная почта",required:""},model:{value:e.registerData.email,callback:function(t){e.$set(e.registerData,"email",t)},expression:"registerData.email"}})],1),e._v(" "),r("v-col",{attrs:{cols:"12",md:"6"}},[r("v-text-field",{attrs:{label:"Телефон"},model:{value:e.registerData.phone,callback:function(t){e.$set(e.registerData,"phone",t)},expression:"registerData.phone"}})],1)],1),e._v(" "),r("v-row",[r("v-col",{attrs:{cols:"12",md:"6"}},[r("v-text-field",{attrs:{"append-icon":e.showPass?"mdi-eye":"mdi-eye-off",rules:e.rules.password,type:e.showPass?"text":"password",label:"Пароль",counter:"",required:""},on:{"click:append":function(t){e.showPass=!e.showPass}},model:{value:e.registerData.password,callback:function(t){e.$set(e.registerData,"password",t)},expression:"registerData.password"}})],1),e._v(" "),r("v-col",{attrs:{cols:"12",md:"6"}},[r("v-text-field",{attrs:{"append-icon":e.showVerifyPass?"mdi-eye":"mdi-eye-off",rules:[e.rules.required,e.passwordMatch],type:e.showVerifyPass?"text":"password",label:"Подтверждение пароля",counter:"",required:""},on:{"click:append":function(t){e.showVerifyPass=!e.showVerifyPass}},model:{value:e.verifyPassword,callback:function(t){e.verifyPassword=t},expression:"verifyPassword"}})],1)],1),e._v(" "),r("v-row",[r("v-col",{attrs:{cols:"12"}},[r("v-btn",{staticClass:"mt-8",attrs:{disabled:!e.valid,color:"primary"},on:{click:e.register}},[e._v("\n        Регистрация\n      ")])],1)],1)],1)}),[],!1,null,null,null);t.default=component.exports;d()(component,{VBtn:f.a,VCol:m.a,VForm:h.a,VRow:v.a,VTextField:w.a})},381:function(e,t,r){"use strict";var n=r(1),o=(r(48),r(67),r(167),r(13),r(12),r(66),r(163),r(11),r(10),r(18),r(19),r(31)),l=r(106),c=r(166);function d(object,e){var t=Object.keys(object);if(Object.getOwnPropertySymbols){var r=Object.getOwnPropertySymbols(object);e&&(r=r.filter((function(e){return Object.getOwnPropertyDescriptor(object,e).enumerable}))),t.push.apply(t,r)}return t}function f(e){for(var i=1;i<arguments.length;i++){var source=null!=arguments[i]?arguments[i]:{};i%2?d(Object(source),!0).forEach((function(t){Object(n.a)(e,t,source[t])})):Object.getOwnPropertyDescriptors?Object.defineProperties(e,Object.getOwnPropertyDescriptors(source)):d(Object(source)).forEach((function(t){Object.defineProperty(e,t,Object.getOwnPropertyDescriptor(source,t))}))}return e}t.a=Object(o.a)(l.a,Object(c.b)("form")).extend({name:"v-form",provide:function(){return{form:this}},inheritAttrs:!1,props:{disabled:Boolean,lazyValidation:Boolean,readonly:Boolean,value:Boolean},data:function(){return{inputs:[],watchers:[],errorBag:{}}},watch:{errorBag:{handler:function(e){var t=Object.values(e).includes(!0);this.$emit("input",!t)},deep:!0,immediate:!0}},methods:{watchInput:function(input){var e=this,t=function(input){return input.$watch("hasError",(function(t){e.$set(e.errorBag,input._uid,t)}),{immediate:!0})},r={_uid:input._uid,valid:function(){},shouldValidate:function(){}};return this.lazyValidation?r.shouldValidate=input.$watch("shouldValidate",(function(n){n&&(e.errorBag.hasOwnProperty(input._uid)||(r.valid=t(input)))})):r.valid=t(input),r},validate:function(){return 0===this.inputs.filter((function(input){return!input.validate(!0)})).length},reset:function(){this.inputs.forEach((function(input){return input.reset()})),this.resetErrorBag()},resetErrorBag:function(){var e=this;this.lazyValidation&&setTimeout((function(){e.errorBag={}}),0)},resetValidation:function(){this.inputs.forEach((function(input){return input.resetValidation()})),this.resetErrorBag()},register:function(input){this.inputs.push(input),this.watchers.push(this.watchInput(input))},unregister:function(input){var e=this.inputs.find((function(i){return i._uid===input._uid}));if(e){var t=this.watchers.find((function(i){return i._uid===e._uid}));t&&(t.valid(),t.shouldValidate()),this.watchers=this.watchers.filter((function(i){return i._uid!==e._uid})),this.inputs=this.inputs.filter((function(i){return i._uid!==e._uid})),this.$delete(this.errorBag,e._uid)}}},render:function(e){var t=this;return e("form",{staticClass:"v-form",attrs:f({novalidate:!0},this.attrs$),on:{submit:function(e){return t.$emit("submit",e)}}},this.$slots.default)}})}}]);