const ENV = {
  dev: {
    apiUrl: 'http://192.168.5.122:44379',
    oAuthConfig: {
      issuer: 'http://192.168.5.122:44379',
      clientId: 'ReservasApp_Native',
      clientSecret: '1q2w3e*',
      scope: 'offline_access ReservasApp',
    },
    localization: {
      defaultResourceName: 'ReservasApp',
    },
  },
  prod: {
    apiUrl: 'http://192.168.5.122:44379',
    oAuthConfig: {
      issuer: 'http://192.168.5.122:44379',
      clientId: 'ReservasApp_Native',
      clientSecret: '1q2w3e*',
      scope: 'offline_access ReservasApp',
    },
    localization: {
      defaultResourceName: 'ReservasApp',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
