FROM ghcr.io/watsonops/simplewhale:v0.0.1
COPY static /usr/share/nginx/html
LABEL maintainer = "watson.ops@gmail.com"

