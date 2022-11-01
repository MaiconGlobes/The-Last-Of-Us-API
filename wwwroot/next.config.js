const withImages = require('next-images');
module.exports = withImages();

module.exports = {
  experimental: {
    swcMinifyDebugOptions: {
      compress: {
        defaults: true,
        side_effects: false,
      },
    },
    forceSwcTransforms: true,
  },
  swcMinify: true,
};
