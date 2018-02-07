# Libbitcoin Server for Feathercoin

*Feathercoin full node and query server*

[Documentation](https://github.com/libbitcoin/libbitcoin-server/wiki) is available on the upstream libbitcoin wiki.

**About**

This install.sh script builds [libbitcoin-server](https://github.com/libbitcoin/libbitcoin-server) for [Feathercoin](https://www.feathercoin.com/).

The [Feathercoin Development Foundation](https://feathercoin.foundation/) is working upstream with the [libbitcoin project](https://libbitcoin.org/) to provide an advanced node and blockchain query server for Feathercoin. This collaboration is also beneficial for Bitcoin as the work the foundations developers contribute is to 90% useful for both coins. We are very thankful for the hard work Eric Voskuil, Amir Taaki and the other libbitcoin contributors as well as Bitcoin Core have built and are looking forward to contribute our part to Bitcoin and the Bitcoin-based ecosystems.

**About Libbitcoin**

The libbitcoin toolkit is a set of cross platform C++ libraries for building bitcoin/feathercoin applications. The toolkit consists of several libraries, most of which depend on the foundational [libbitcoin](https://github.com/libbitcoin/libbitcoin) library. Each library's repository can be cloned and built using common [Automake](http://www.gnu.org/software/automake) instructions.

**About Libbitcoin Server**

A full Bitcoin/Feathercoin peer-to-peer node, Libbitcoin Server is also a high performance blockchain query server. It can be built as a single portable executable for Linux, macOS or Windows. It is trivial to deploy, just run the single process and allow it about two days to synchronize the Bitcoin/Feathercoin blockchain.

Libbitcoin Server exposes a custom query TCP API built based on the [ZeroMQ](http://zeromq.org) networking stack. It supports server, and optionally client, identity certificates and wire encryption via [CurveZMQ](http://curvezmq.org) and the [Sodium](http://libsodium.org) cryptographic library.

The API supports simple and advanced scenarios, including stealth payment queries. The [libbitcoin-client](https://github.com/libbitcoin/libbitcoin-client) library provides a calling API for building client applications. The server is complimented by [libbitcoin-explorer (BX)](https://github.com/libbitcoin/libbitcoin-explorer), a Bitcoin/Feathercoin command line tool.

## Hardware Requirements.

At least 100 Gb file storage (SSD preferred), with swap enabled and at least 4Gb RAM (8Gb preferred).

## Ubuntu 16.04 fast build.

```sh
sudo apt-get install build-essential autoconf automake libtool pkg-config
wget https://raw.githubusercontent.com/Feathercoin-Foundation/libbitcoin-server-ftc/master/install.sh
chmod +x install.sh
./install.sh CXXFLAGS="-Os -s" --without-tests --disable-shared --build-boost --build-zmq --with-bash-completion-dir --prefix=/home/ubuntu/libbitcoin-server
```

For more detailed build instructions see the [upstream repository](https://github.com/libbitcoin/libbitcoin-server).
