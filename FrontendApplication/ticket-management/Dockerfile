FROM node:18 AS build
WORKDIR /app
COPY package.json .
COPY package-lock.json .
COPY . .
RUN npm install
RUN npm run build

FROM nginx:alpine
COPY nginx.conf /etc/nginx/conf.d/default.conf
COPY --from=build /app/build/ /etc/nginx/html/

WORKDIR /etc/nginx/html/
EXPOSE 80
EXPOSE 443
CMD ["nginx","-g","daemon off;"]