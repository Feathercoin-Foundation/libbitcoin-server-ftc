#!/bin/bash -e
CFG="
# Libbitcoin Server configuration file for Feathercoin

[log]
# The debug log file path, defaults to 'debug.log'.
debug_file = debug.log
# The error log file path, defaults to 'error.log'.
error_file = error.log
# The log archive directory, defaults to 'archive'.
archive_directory = archive
# The size at which a log is archived, defaults to 10000000 (0 disables).
rotation_size = 10000000
# The minimum free space required in the archive directory, defaults to 0.
minimum_free_space = 0
# The maximum combined size of archived logs, defaults to 0 (maximum).
maximum_archive_size = 0
# The maximum number of logs to archive, defaults to 0 (maximum).
maximum_archive_files = 0
# The address of the statistics collection server, defaults to none.
statistics_server = 0.0.0.0:0
# Enable verbose logging, defaults to false.
verbose = false

[network]
# The minimum number of threads in the network threadpool, defaults to 0 (physical cores).
threads = 0
# The maximum network protocol version, defaults to 70013.
protocol_maximum = 70013
# The minimum network protocol version, defaults to 60008 for Feathercoin.
protocol_minimum = 60008
# The services exposed by network connections, defaults to 9 (full node, witness).
services = 9
# The advertised services that cause a peer to be dropped, defaults to 160.
invalid_services = 160
# The magic number for message headers,  defaults to 3686187259 for Feathercoin (use 3131420634 for Feathercoin testnet).
identifier = 3686187259
# Validate the checksum of network messages, defaults to false.
validate_checksum = false
# The port for incoming connections, defaults to 9336 for Feathercoin (use 19336 for Feathercoin testnet).
inbound_port = 9336
# The target number of incoming network connections, defaults to 0.
inbound_connections = 0
# The target number of outgoing network connections, defaults to 2.
outbound_connections = 2
# The attempt limit for manual connection establishment, defaults to 0 (forever).
manual_attempt_limit = 0
# The number of concurrent attempts to establish one connection, defaults to 5.
connect_batch_size = 5
# The time limit for connection establishment, defaults to 5.
connect_timeout_seconds = 5
# The time limit to complete the connection handshake, defaults to 30.
channel_handshake_seconds = 30
# The time between ping messages, defaults to 5.
channel_heartbeat_minutes = 5
# The inactivity time limit for any connection, defaults to 30.
channel_inactivity_minutes = 30
# The age limit for any connection, defaults to 60.
channel_expiration_minutes = 60
# The time limit for obtaining seed addresses, defaults to 30.
channel_germination_seconds = 30
# The maximum number of peer hosts in the pool, defaults to 1000.
host_pool_capacity = 1000
# The peer hosts cache file path, defaults to 'hosts.cache'.
hosts_file = hosts.cache
# The advertised public address of this node, defaults to none.
self = 0.0.0.0:0
# IP address to disallow as a peer, multiple entries allowed.
#blacklist = 127.0.0.1
# A persistent peer node, multiple entries allowed.
#peer = libbitcoin-ch-1.feathercoin.ch:9336
#peer = libbitcoin-ch-1.testnet.feathercoin.ch:19336
# A seed node for initializing the host pool, multiple entries allowed, defaults shown.
seed = libbitcoin-ch-1.feathercoin.ch:9336
# Testnet seed nodes.
#seed = libbitcoin-ch-1.testnet.feathercoin.ch:19336

[database]
# The blockchain database directory, defaults to 'blockchain'.
directory = blockchain
# Flush each write to disk, defaults to false.
flush_writes = false
# Full database files increase by this percentage, defaults to 50.
file_growth_rate = 50
# Block hash table size, defaults to 650000.
block_table_buckets = 650000
# Transaction hash table size, defaults to 110000000.
transaction_table_buckets = 110000000
# History hash table size, defaults to 107000000.
history_table_buckets = 107000000
# Spend hash table size, defaults to 250000000.
spend_table_buckets = 250000000
# The maximum number of entries in the unspent outputs cache, defaults to 10000.
cache_capacity = 10000

[blockchain]
# The number of cores dedicated to block validation, defaults to 0 (physical cores).
cores = 0
# Use high thread priority for block validation, defaults to true.
priority = true
# Use libconsensus for script validation if integrated, defaults to false.
use_libconsensus = false
# The maximum reorganization depth, defaults to 256 (0 for unlimited).
reorganization_limit = 256
# A hash:height checkpoint, multiple entries allowed, defaults for Feathercoin shown.
checkpoint = 12a765e31ffd4059bada1e25190f6e98c99d9714d334efa41a195a7e7e04bfe2:0
checkpoint = fdbe99b90c90bae7505796461471d89ae8388ab953997aa06a355bbda8d915cb:1
checkpoint = 23dc7d871fc2a9b994112e978019f6370bab0b8979f557afe77a7ab620224b70:22267
checkpoint = 1450b80c150fee1e657ee8309819276342c021fab5e6a20ccf5407f5e2218d0f:22847
checkpoint = 7c25d3f9671e1d9400c9a1be2ff68e68db561ab85ae6b7020062d8d26da81e4c:23453
checkpoint = d3feb71f92c63c682f994d7c615adc425226c669a83d46012b32fc8d518b08bb:28230
checkpoint = ba7d5c0e6d46f6448253290ce037e13975c13ca9c375ae854b6b2f85044fc0f9:31846
checkpoint = 023cf4acfd8bf0114090a7ce048e79ac28152de78bb41f1277742904494e6c49:33918
checkpoint = 082f5d9023af3f068733ab68cf81b741f58e3c75ae28d2a9bd07f30b74c38356:34000
checkpoint = 8c4e02f6c0d20e856fd7e952a147fee30ce145ca6932a284f354924362d2b408:41300
checkpoint = 93515f222f16a9ff3db6594e5ee7c12924cff9ba05b01dbe551d0a9e65dd141f:1114311
checkpoint = e97230c788e7240eb325576810fee62f5162905f63a832f15928b88ac6a938c6:1593400
checkpoint = 4f6de194bd2f4580e2ac9337289c7cca348d3f35c9079af2760b288315b82feb:1776411
# Testnet checkpoints for Feathercoin.
#checkpoint = 7734b3734ab1f0d0758e6c274622a377092549df05f6a4fe6939cbc754939169:0

[fork]
# Allow minimum difficulty blocks, defaults to false (use true for testnet).
easy_blocks = false
# Retarget difficulty, defaults to true (use false for regtest).
retarget = true
# Add pay-to-script-hash processing, defaults to true (soft fork).
bip16 = true
# Disallow collision of unspent transaction hashes, defaults to true (soft fork).
bip30 = true
# Require coinbase input includes block height, defaults to true (soft fork).
bip34 = true
# Require strict signature encoding, defaults to true (soft fork).
bip66 = true
# Add check-locktime-verify op code, defaults to true (soft fork). Not yet activated for Feathercoin.
bip65 = false
# Assume bip34, bip65, and bip66 activation if enabled, defaults to true (hard fork). Feathercoin: LCLC NOT SURE, ACTUALLY IMPLEMENTED IN A UGLY WAY.
bip90 = true
# Add relative locktime enforcement, defaults to true (soft fork). Not yet activated for Feathercoin.
bip68 = false
# Add check-sequence-verify op code, defaults to true (soft fork). Not yet activated for Feathercoin.
bip112 = false
# Use median time past for locktime, defaults to true (soft fork). Not yet activated for Feathercoin.
bip113 = false
# Segregated witness consensus layer, defaults to true (soft fork). Not yet activated for Feathercoin.
bip141 = false
# Version 0 transaction digest, defaults to true (soft fork). Not yet activated for Feathercoin.
bip143 = false
# Prevent dummy value malleability, defaults to true (soft fork). Not yet activated for Feathercoin.
bip147 = false

[node]
# The time to wait for a requested block, defaults to 60.
block_latency_seconds = 60
# Disable relay when top block age exceeds, defaults to 24 (0 disables).
notify_limit_hours = 24
# The minimum fee per byte, cumulative for conflicts, defaults to 1.
byte_fee_satoshis = 1
# The minimum fee per sigop, additional to byte fee, defaults to 100.
sigop_fee_satoshis = 100
# The minimum output value, defaults to 500.
minimum_output_satoshis = 500
# Request that peers relay transactions, defaults to true.
relay_transactions = true
# Request transactions on each channel start, defaults to true.
refresh_transactions = true

[server]
# The lower limit of address and spend indexing, defaults to 0.
index_start_height = 0
# Drop messages at this outgoing backlog level, defaults to 100.
send_high_water = 100
# Drop messages at this incoming backlog level, defaults to 100.
receive_high_water = 100
# The time limit to complete the connection handshake, defaults to 30.
handshake_seconds = 30
# Disable public endpoints, defaults to false.
secure_only = false
# The number of query worker threads per endpoint, defaults to 1 (0 disables service).
query_workers = 1
# The maximum number of query subscriptions, defaults to 1000 (0 disables subscribe).
subscription_limit = 1000
# The query subscription expiration time, defaults to 10 (0 disables expiration).
subscription_expiration_minutes = 10
# The heartbeat service interval, defaults to 5 (0 disables service).
heartbeat_service_seconds = 5
# Enable the block publishing service, defaults to true.
block_service_enabled = true
# Enable the transaction publishing service, defaults to true.
transaction_service_enabled = true

# The secure query endpoint, defaults to 'tcp://*:9081'.
secure_query_endpoint = tcp://*:9081
# The secure heartbeat endpoint, defaults to 'tcp://*:9082'.
secure_heartbeat_endpoint = tcp://*:9082
# The secure block publishing endpoint, defaults to 'tcp://*:9083'.
secure_block_endpoint = tcp://*:9083
# The secure transaction publishing endpoint, defaults to 'tcp://*:9084'.
secure_transaction_endpoint = tcp://*:9084

# The public query endpoint, defaults to 'tcp://*:9091'.
public_query_endpoint = tcp://*:9091
# The public heartbeat endpoint, defaults to 'tcp://*:9092'.
public_heartbeat_endpoint = tcp://*:9092
# The public block publishing endpoint, defaults to 'tcp://*:9093'.
public_block_endpoint = tcp://*:9093
# The public transaction publishing endpoint, defaults to 'tcp://*:9094'.
public_transaction_endpoint = tcp://*:9094

# The Z85-encoded private key of the server, enables secure endpoints.
#server_private_key =
# Allowed Z85-encoded public key of the client, multiple entries allowed.
#client_public_key =
# Allowed client IP address, multiple entries allowed.
#client_address = 127.0.0.1
# Blocked client IP address, multiple entries allowed.
#blacklist = 127.0.0.1
"

BS_CONFIG=<(echo "$CFG") bs "$@"
