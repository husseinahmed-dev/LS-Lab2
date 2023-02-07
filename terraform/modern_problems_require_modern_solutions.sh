#!/bin/bash

terraform init

terraform plan -out main.tfplan

terraform apply main.tfplan

bash post_terraform.sh