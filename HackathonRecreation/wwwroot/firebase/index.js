import createApp from './app.js'

import authService from './service.auth.js'
import firestoreService from './service.firestore.js'

const appConfig = {"apiKey":"AIzaSyDTGEjhL8XnYP6eQNH2YmziQ3wFJDu0dXA","authDomain":"hackaton-2021-sanatorium.firebaseapp.com","projectId":"hackaton-2021-sanatorium","storageBucket":"hackaton-2021-sanatorium.appspot.com","messagingSenderId":"99038969564","appId":"1:99038969564:web:ccb2ba21e3227e6c22fe19","measurementId":"G-B4Q8XJ8YBL"}

export default async (ctx, inject) => {
  const { firebase, session } = await createApp(appConfig, ctx)

  let servicePromises = []

  if (process.server) {
    servicePromises = [
      authService(session, firebase, ctx, inject),
    firestoreService(session, firebase, ctx, inject),

    ]
  }

  if (process.client) {
    servicePromises = [
      authService(session, firebase, ctx, inject),
      firestoreService(session, firebase, ctx, inject),

    ]
  }

  const [
    auth,
    firestore
  ] = await Promise.all(servicePromises)

  const fire = {
    auth: auth,
    firestore: firestore
  }

    inject('fireModule', firebase)
    ctx.$fireModule = firebase

  inject('fire', fire)
  ctx.$fire = fire
}

function forceInject (ctx, inject, key, value) {
  inject(key, value)
  const injectKey = '$' + key
  ctx[injectKey] = value
  if (typeof window !== "undefined" && window.$nuxt) {
  // If clause makes sure it's only run when ready() is called in a component, not in a plugin.
    window.$nuxt.$options[injectKey] = value
  }
}