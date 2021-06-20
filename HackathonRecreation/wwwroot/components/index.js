import { wrapFunctional } from './utils'

export { default as FilterPanelComponent } from '../..\\components\\FilterPanelComponent.vue'
export { default as FindSanatorium } from '../..\\components\\FindSanatorium.vue'
export { default as RegisterForm } from '../..\\components\\RegisterForm.vue'
export { default as SignInForm } from '../..\\components\\SignInForm.vue'

export const LazyFilterPanelComponent = import('../..\\components\\FilterPanelComponent.vue' /* webpackChunkName: "components/filter-panel-component" */).then(c => wrapFunctional(c.default || c))
export const LazyFindSanatorium = import('../..\\components\\FindSanatorium.vue' /* webpackChunkName: "components/find-sanatorium" */).then(c => wrapFunctional(c.default || c))
export const LazyRegisterForm = import('../..\\components\\RegisterForm.vue' /* webpackChunkName: "components/register-form" */).then(c => wrapFunctional(c.default || c))
export const LazySignInForm = import('../..\\components\\SignInForm.vue' /* webpackChunkName: "components/sign-in-form" */).then(c => wrapFunctional(c.default || c))
