#!/bin/bash

# Run terraform plan and specify the destory flag
terraform plan -destroy -out main.destroy.tfplan

# Runn Terraform apply to apply the execution plan
terraform apply main.destroy.tfplan
