#!/bin/bash

# Store Terraform's output of tls_private_key in a file named id_rsa
terraform output -raw tls_private_key > ../ansible/files/id_rsa

# Change tls_private_key permissions
chmod 400 ../ansible/files/id_rsa

# Store Terraform's output of public_ip_address in a variable
TEST_IP_ADDRESS=$(terraform output public_ip_address)

# Public IP string manipulation
PUBLIC_IP_ADDRESS=$(echo $TEST_IP_ADDRESS | tr -d '"')

# Use the stored private key and public IP address to ssh into the remote machine
ssh -i ../ansible/files/id_rsa azureuser@$PUBLIC_IP_ADDRESS