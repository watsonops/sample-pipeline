FROM nginx:alpine
COPY static /usr/share/nginx/html
LABEL maintainer = "watson.ops@gmail.com"

