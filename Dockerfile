FROM ghcr.io/watsonops/simplewhale:v1.0.0
COPY static /usr/share/nginx/html
LABEL maintainer = "watson.ops@gmail.com"

