exports.ids = [2];
exports.modules = {

/***/ 102:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "a", function() { return VCardActions; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "b", function() { return VCardSubtitle; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "c", function() { return VCardText; });
/* harmony export (binding) */ __webpack_require__.d(__webpack_exports__, "d", function() { return VCardTitle; });
/* harmony import */ var _VCard__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(106);
/* harmony import */ var _util_helpers__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(1);


const VCardActions = Object(_util_helpers__WEBPACK_IMPORTED_MODULE_1__[/* createSimpleFunctional */ "g"])('v-card__actions');
const VCardSubtitle = Object(_util_helpers__WEBPACK_IMPORTED_MODULE_1__[/* createSimpleFunctional */ "g"])('v-card__subtitle');
const VCardText = Object(_util_helpers__WEBPACK_IMPORTED_MODULE_1__[/* createSimpleFunctional */ "g"])('v-card__text');
const VCardTitle = Object(_util_helpers__WEBPACK_IMPORTED_MODULE_1__[/* createSimpleFunctional */ "g"])('v-card__title');

/* unused harmony default export */ var _unused_webpack_default_export = ({
  $_vuetify_subcomponents: {
    VCard: _VCard__WEBPACK_IMPORTED_MODULE_0__[/* default */ "a"],
    VCardActions,
    VCardSubtitle,
    VCardText,
    VCardTitle
  }
});

/***/ }),

/***/ 146:
/***/ (function(module, __webpack_exports__, __webpack_require__) {

"use strict";
// ESM COMPAT FLAG
__webpack_require__.r(__webpack_exports__);

// CONCATENATED MODULE: ./node_modules/vue-loader/lib/loaders/templateLoader.js??vue-loader-options!./node_modules/@nuxt/components/dist/loader.js??ref--0-0!./node_modules/vue-loader/lib??vue-loader-options!./components/FindSanatorium.vue?vue&type=template&id=44fbc696&
var render = function () {var _vm=this;var _h=_vm.$createElement;var _c=_vm._self._c||_h;return _c('v-sheet',{staticClass:"d-flex flex-wrap pt-8 pr-4 pl-4",attrs:{"color":"white","elevation":"1"}},_vm._l((_vm.sanatoriums),function(item){return _c('v-card',{key:item.id,staticClass:"mx-auto mr-8 ml-8 mb-8",attrs:{"width":"412"}},[_c('v-img',{staticClass:"white--text align-end",attrs:{"height":"200px","src":'http://localhost:5000' + item.imageLink[0]}},[_c('v-card-title',[_vm._v(_vm._s(item.name))])],1),_vm._v(" "),_c('v-card-subtitle',{staticClass:"pb-0"},[_vm._v("\n          "+_vm._s(item.contacts.phone)+"\n        ")]),_vm._v(" "),_c('v-card-text',{staticClass:"text--primary"},[_vm._v(_vm._s(item.contacts.address))]),_vm._v(" "),_c('v-card-actions',[_c('v-btn',{attrs:{"color":"accent","text":"","exact":"","to":'/sanatorium/' + item.id}},[_vm._v("Подробно")])],1)],1)}),1)}
var staticRenderFns = []


// CONCATENATED MODULE: ./components/FindSanatorium.vue?vue&type=template&id=44fbc696&

// EXTERNAL MODULE: external "vuex"
var external_vuex_ = __webpack_require__(17);

// CONCATENATED MODULE: ./node_modules/babel-loader/lib??ref--2-0!./node_modules/@nuxt/components/dist/loader.js??ref--0-0!./node_modules/vue-loader/lib??vue-loader-options!./components/FindSanatorium.vue?vue&type=script&lang=js&
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//
//

/* harmony default export */ var FindSanatoriumvue_type_script_lang_js_ = ({
  computed: {
    sanatoriums: {
      get() {
        return this.$store.state.sanatoriums;
      },

      set(value) {
        this.$store.commit("SET_SANATORIUMS", value);
      }

    }
  },

  async fetch() {
    await this.$store.dispatch("fetchSanatoriums");
  }

});
// CONCATENATED MODULE: ./components/FindSanatorium.vue?vue&type=script&lang=js&
 /* harmony default export */ var components_FindSanatoriumvue_type_script_lang_js_ = (FindSanatoriumvue_type_script_lang_js_); 
// EXTERNAL MODULE: ./node_modules/vue-loader/lib/runtime/componentNormalizer.js
var componentNormalizer = __webpack_require__(12);

// EXTERNAL MODULE: ./node_modules/vuetify-loader/lib/runtime/installComponents.js
var installComponents = __webpack_require__(20);
var installComponents_default = /*#__PURE__*/__webpack_require__.n(installComponents);

// EXTERNAL MODULE: ./node_modules/vuetify/lib/components/VBtn/VBtn.js + 2 modules
var VBtn = __webpack_require__(108);

// EXTERNAL MODULE: ./node_modules/vuetify/lib/components/VCard/VCard.js
var VCard = __webpack_require__(106);

// EXTERNAL MODULE: ./node_modules/vuetify/lib/components/VCard/index.js
var components_VCard = __webpack_require__(102);

// EXTERNAL MODULE: ./node_modules/vuetify/lib/components/VImg/VImg.js + 2 modules
var VImg = __webpack_require__(61);

// EXTERNAL MODULE: ./node_modules/vuetify/lib/components/VSheet/VSheet.js
var VSheet = __webpack_require__(16);

// CONCATENATED MODULE: ./components/FindSanatorium.vue





/* normalize component */

var component = Object(componentNormalizer["a" /* default */])(
  components_FindSanatoriumvue_type_script_lang_js_,
  render,
  staticRenderFns,
  false,
  null,
  null,
  "1ed0f5b6"
  
)

/* harmony default export */ var FindSanatorium = __webpack_exports__["default"] = (component.exports);

/* vuetify-loader */









installComponents_default()(component, {VBtn: VBtn["a" /* default */],VCard: VCard["a" /* default */],VCardActions: components_VCard["a" /* VCardActions */],VCardSubtitle: components_VCard["b" /* VCardSubtitle */],VCardText: components_VCard["c" /* VCardText */],VCardTitle: components_VCard["d" /* VCardTitle */],VImg: VImg["a" /* default */],VSheet: VSheet["a" /* default */]})


/***/ })

};;
//# sourceMappingURL=find-sanatorium.js.map