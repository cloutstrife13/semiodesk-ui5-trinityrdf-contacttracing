FROM node:10.13-alpine
ENV NODE_ENV production
WORKDIR /usr/src/app
COPY ["package.json", "package-lock.json*", "npm-shrinkwrap.json*", ".babelrc", "./"]
RUN npm install --production --silent
COPY . .
EXPOSE 7200
ENTRYPOINT ["npm", "start"]