import admin from 'firebase-admin'

const config = {"apiKey":"AIzaSyDTGEjhL8XnYP6eQNH2YmziQ3wFJDu0dXA","authDomain":"hackaton-2021-sanatorium.firebaseapp.com","projectId":"hackaton-2021-sanatorium","storageBucket":"hackaton-2021-sanatorium.appspot.com","messagingSenderId":"99038969564","appId":"1:99038969564:web:ccb2ba21e3227e6c22fe19","measurementId":"G-B4Q8XJ8YBL"}

const simulateUserRecord = ({
  uid,
  email,
  email_verified: emailVerified,
  name: displayName
}) => ({
  uid,
  email,
  emailVerified,
  displayName
})

if (!admin.apps.length) {
  admin.initializeApp(config)
}

export default async ({ req, res }) => {
  if (!req || !req.headers.authorization) {
    return
  }

  // Parse the injected ID token from the request header.
  const authorizationHeader = req.headers.authorization || ''
  const components = authorizationHeader.split(' ')
  const idToken = components.length > 1 ? components[1] : ''

  try {
    // Try to verify the id token, additionally checking if the token was revoked
    const decodedToken = await admin.auth().verifyIdToken(idToken)

    if (decodedToken.uid) {
      const authUser = simulateUserRecord(decodedToken)

      res.locals = {
        ...res.locals,
        user: {
          ...authUser,
					allClaims: decodedToken,
					idToken,
        }
      }
    }
  } catch (e) {
    console.error(e)
  }
}
