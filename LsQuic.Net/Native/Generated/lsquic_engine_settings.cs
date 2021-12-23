namespace StirlingLabs.LsQuic.Native
{
    public unsafe partial struct lsquic_engine_settings
    {
        [NativeTypeName("unsigned int")]
        public uint es_versions;

        [NativeTypeName("unsigned int")]
        public uint es_cfcw;

        [NativeTypeName("unsigned int")]
        public uint es_sfcw;

        [NativeTypeName("unsigned int")]
        public uint es_max_cfcw;

        [NativeTypeName("unsigned int")]
        public uint es_max_sfcw;

        [NativeTypeName("unsigned int")]
        public uint es_max_streams_in;

        [NativeTypeName("unsigned long")]
        public nuint es_handshake_to;

        [NativeTypeName("unsigned long")]
        public nuint es_idle_conn_to;

        public int es_silent_close;

        [NativeTypeName("unsigned int")]
        public uint es_max_header_list_size;

        [NativeTypeName("const char *")]
        public sbyte* es_ua;

        [NativeTypeName("uint64_t")]
        public ulong es_sttl;

        [NativeTypeName("uint32_t")]
        public uint es_pdmd;

        [NativeTypeName("uint32_t")]
        public uint es_aead;

        [NativeTypeName("uint32_t")]
        public uint es_kexs;

        [NativeTypeName("unsigned int")]
        public uint es_max_inchoate;

        public int es_support_push;

        public int es_support_tcid0;

        public int es_support_nstp;

        public int es_honor_prst;

        public int es_send_prst;

        [NativeTypeName("unsigned int")]
        public uint es_progress_check;

        public int es_rw_once;

        [NativeTypeName("unsigned int")]
        public uint es_proc_time_thresh;

        public int es_pace_packets;

        [NativeTypeName("unsigned int")]
        public uint es_clock_granularity;

        [NativeTypeName("unsigned int")]
        public uint es_cc_algo;

        [NativeTypeName("unsigned int")]
        public uint es_cc_rtt_thresh;

        [NativeTypeName("unsigned int")]
        public uint es_noprogress_timeout;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_data;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_stream_data_bidi_remote;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_stream_data_bidi_local;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_stream_data_uni;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_streams_bidi;

        [NativeTypeName("unsigned int")]
        public uint es_init_max_streams_uni;

        [NativeTypeName("unsigned int")]
        public uint es_idle_timeout;

        [NativeTypeName("unsigned int")]
        public uint es_ping_period;

        [NativeTypeName("unsigned int")]
        public uint es_scid_len;

        [NativeTypeName("unsigned int")]
        public uint es_scid_iss_rate;

        [NativeTypeName("unsigned int")]
        public uint es_qpack_dec_max_size;

        [NativeTypeName("unsigned int")]
        public uint es_qpack_dec_max_blocked;

        [NativeTypeName("unsigned int")]
        public uint es_qpack_enc_max_size;

        [NativeTypeName("unsigned int")]
        public uint es_qpack_enc_max_blocked;

        public int es_ecn;

        public int es_allow_migration;

        public int es_ql_bits;

        public int es_spin;

        public int es_delayed_acks;

        public int es_timestamps;

        [NativeTypeName("unsigned short")]
        public ushort es_max_udp_payload_size_rx;

        public int es_grease_quic_bit;

        public int es_dplpmtud;

        [NativeTypeName("unsigned short")]
        public ushort es_base_plpmtu;

        [NativeTypeName("unsigned short")]
        public ushort es_max_plpmtu;

        [NativeTypeName("unsigned int")]
        public uint es_mtu_probe_timer;

        public int es_datagrams;

        public int es_optimistic_nat;

        public int es_ext_http_prio;

        public int es_qpack_experiment;

        [NativeTypeName("unsigned int")]
        public uint es_ptpc_periodicity;

        [NativeTypeName("unsigned int")]
        public uint es_ptpc_max_packtol;

        public int es_ptpc_dyn_target;

        public float es_ptpc_target;

        public float es_ptpc_prop_gain;

        public float es_ptpc_int_gain;

        public float es_ptpc_err_thresh;

        public float es_ptpc_err_divisor;

        public int es_delay_onclose;

        [NativeTypeName("unsigned int")]
        public uint es_max_batch_size;

        public int es_check_tp_sanity;
    }
}
