import Vue from 'vue'
import { wrapFunctional } from './utils'

const components = {
  FilterPanelComponent: () => import('../..\\components\\FilterPanelComponent.vue' /* webpackChunkName: "components/filter-panel-component" */).then(c => wrapFunctional(c.default || c)),
  FindSanatorium: () => import('../..\\components\\FindSanatorium.vue' /* webpackChunkName: "components/find-sanatorium" */).then(c => wrapFunctional(c.default || c)),
  RegisterForm: () => import('../..\\components\\RegisterForm.vue' /* webpackChunkName: "components/register-form" */).then(c => wrapFunctional(c.default || c)),
  SignInForm: () => import('../..\\components\\SignInForm.vue' /* webpackChunkName: "components/sign-in-form" */).then(c => wrapFunctional(c.default || c))
}

for (const name in components) {
  Vue.component(name, components[name])
  Vue.component('Lazy' + name, components[name])
}
