// FeatEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatEntity
    {
        public FeatEntity(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::System.String? special,
            global::System.String? trigger,
            global::StrawberryShake.EntityId? frequency,
            global::StrawberryShake.EntityId? rollableEffect,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> traits,
            global::System.Boolean canBeLearnedMoreThanOnce,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> details)
        {
            Id = id;
            Name = name;
            Level = level;
            Special = special;
            Trigger = trigger;
            Frequency = frequency;
            RollableEffect = rollableEffect;
            Traits = traits;
            CanBeLearnedMoreThanOnce = canBeLearnedMoreThanOnce;
            Details = details;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.String? Special { get; }

        public global::System.String? Trigger { get; }

        public global::StrawberryShake.EntityId? Frequency { get; }

        public global::StrawberryShake.EntityId? RollableEffect { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Traits { get; }

        public global::System.Boolean CanBeLearnedMoreThanOnce { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Details { get; }
    }
}


// FrequencyEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FrequencyEntity
    {
        public FrequencyEntity(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// RollableEffectEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RollableEffectEntity
    {
        public RollableEffectEntity(
            global::System.String? criticalSuccess,
            global::System.String? success,
            global::System.String? failure,
            global::System.String? criticalFailure)
        {
            CriticalSuccess = criticalSuccess;
            Success = success;
            Failure = failure;
            CriticalFailure = criticalFailure;
        }

        public global::System.String? CriticalSuccess { get; }

        public global::System.String? Success { get; }

        public global::System.String? Failure { get; }

        public global::System.String? CriticalFailure { get; }
    }
}


// TraitEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class TraitEntity
    {
        public TraitEntity(
            global::System.Guid id,
            global::System.String name,
            global::System.String description,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> feats,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> spells)
        {
            Id = id;
            Name = name;
            Description = description;
            Feats = feats;
            Spells = spells;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Feats { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> Spells { get; }
    }
}


// FeatDetailsBlockEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatDetailsBlockEntity
    {
        public FeatDetailsBlockEntity(global::System.String text)
        {
            Text = text;
        }

        public global::System.String Text { get; }
    }
}


// RaceEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceEntity
    {
        public RaceEntity(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 baseSpeed,
            global::System.Int32 baseHealth,
            global::StrawberryShake.EntityId size,
            global::StrawberryShake.EntityId rarity)
        {
            Id = id;
            Name = name;
            BaseSpeed = baseSpeed;
            BaseHealth = baseHealth;
            Size = size;
            Rarity = rarity;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 BaseSpeed { get; }

        public global::System.Int32 BaseHealth { get; }

        public global::StrawberryShake.EntityId Size { get; }

        public global::StrawberryShake.EntityId Rarity { get; }
    }
}


// RaceSizeEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceSizeEntity
    {
        public RaceSizeEntity(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// RaceRarityEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceRarityEntity
    {
        public RaceRarityEntity(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }
    }
}


// SpellEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellEntity
    {
        public SpellEntity(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::StrawberryShake.EntityId magicSchool,
            global::StrawberryShake.EntityId spellType)
        {
            Id = id;
            Name = name;
            Level = level;
            MagicSchool = magicSchool;
            SpellType = spellType;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::StrawberryShake.EntityId MagicSchool { get; }

        public global::StrawberryShake.EntityId SpellType { get; }
    }
}


// MagicSchoolEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class MagicSchoolEntity
    {
        public MagicSchoolEntity(
            global::System.Guid id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }
    }
}


// SpellTypeEntity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellTypeEntity
    {
        public SpellTypeEntity(
            global::System.Guid id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }
    }
}


// GetFeatByIdResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatById_Feats_Items_Feat> _getFeatById_Feats_Items_FeatFromFeatEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, GetFeatById_Feats_Items_Frequency_Frequency> _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, GetFeatById_Feats_Items_RollableEffect_RollableEffect> _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetFeatById_Feats_Items_Traits_Trait> _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper;

        public GetFeatByIdResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatById_Feats_Items_Feat> getFeatById_Feats_Items_FeatFromFeatEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, GetFeatById_Feats_Items_Frequency_Frequency> getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, GetFeatById_Feats_Items_RollableEffect_RollableEffect> getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetFeatById_Feats_Items_Traits_Trait> getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getFeatById_Feats_Items_FeatFromFeatEntityMapper = getFeatById_Feats_Items_FeatFromFeatEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_FeatFromFeatEntityMapper));
            _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper = getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper));
            _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper = getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper));
            _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper = getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult);

        public GetFeatByIdResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetFeatByIdResultInfo info)
            {
                return new GetFeatByIdResult(MapIGetFeatById_Feats(
                    info.Feats,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetFeatByIdResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats? MapIGetFeatById_Feats(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetFeatById_Feats returnValue = default!;

            if (data?.__typename.Equals(
                    "FeatCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetFeatById_Feats_FeatCollectionSegment(MapIGetFeatById_Feats_ItemsArray(
                    data.Items,
                    snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items?>? MapIGetFeatById_Feats_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var feats = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                feats.Add(MapIGetFeatById_Feats_Items(
                    child,
                    snapshot));
            }

            return feats;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items? MapIGetFeatById_Feats_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_FeatFromFeatEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Frequency? MapIGetFeatById_Feats_Items_Frequency(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Frequency",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_RollableEffect? MapIGetFeatById_Feats_Items_RollableEffect(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "RollableEffect",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits> MapNonNullableIGetFeatById_Feats_Items_TraitsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var traits = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                traits.Add(MapNonNullableIGetFeatById_Feats_Items_Traits(
                    child,
                    snapshot));
            }

            return traits;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits MapNonNullableIGetFeatById_Feats_Items_Traits(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetFeatByIdResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetFeatByIdResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? feats,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Feats = feats;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? Feats { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetFeatByIdResultInfo(
                Feats,
                _entityIds,
                version);
        }
    }
}


// GetFeatByIdResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdResult
        : global::System.IEquatable<GetFeatByIdResult>
        , IGetFeatByIdResult
    {
        public GetFeatByIdResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats? feats)
        {
            Feats = feats;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats? Feats { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatByIdResult)obj);
        }

        public global::System.Boolean Equals(GetFeatByIdResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Feats is null && other.Feats is null) ||Feats != null && Feats.Equals(other.Feats)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Feats is null))
                {
                    hash ^= 397 * Feats.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetFeatById_Feats_FeatCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_FeatCollectionSegment
        : global::System.IEquatable<GetFeatById_Feats_FeatCollectionSegment>
        , IGetFeatById_Feats_FeatCollectionSegment
    {
        public GetFeatById_Feats_FeatCollectionSegment(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items?>? items)
        {
            Items = items;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatById_Feats_FeatCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetFeatById_Feats_FeatCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetFeatById_Feats_Items_FeatFromFeatEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_FeatFromFeatEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatById_Feats_Items_Feat>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, GetFeatById_Feats_Items_Frequency_Frequency> _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, GetFeatById_Feats_Items_RollableEffect_RollableEffect> _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetFeatById_Feats_Items_Traits_Trait> _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper;

        public GetFeatById_Feats_Items_FeatFromFeatEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, GetFeatById_Feats_Items_Frequency_Frequency> getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, GetFeatById_Feats_Items_RollableEffect_RollableEffect> getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetFeatById_Feats_Items_Traits_Trait> getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper = getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper));
            _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper = getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper));
            _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper = getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper));
        }

        public GetFeatById_Feats_Items_Feat Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetFeatById_Feats_Items_Feat(
                entity.Id,
                entity.Name,
                entity.Level,
                entity.Special,
                entity.Trigger,
                MapIGetFeatById_Feats_Items_Frequency(
                    entity.Frequency,
                    snapshot),
                MapIGetFeatById_Feats_Items_RollableEffect(
                    entity.RollableEffect,
                    snapshot),
                MapNonNullableIGetFeatById_Feats_Items_TraitsNonNullableArray(
                    entity.Traits,
                    snapshot));
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Frequency? MapIGetFeatById_Feats_Items_Frequency(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Frequency",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_RollableEffect? MapIGetFeatById_Feats_Items_RollableEffect(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "RollableEffect",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits> MapNonNullableIGetFeatById_Feats_Items_TraitsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var traits = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                traits.Add(MapNonNullableIGetFeatById_Feats_Items_Traits(
                    child,
                    snapshot));
            }

            return traits;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits MapNonNullableIGetFeatById_Feats_Items_Traits(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetFeatById_Feats_Items_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_Feat
        : global::System.IEquatable<GetFeatById_Feats_Items_Feat>
        , IGetFeatById_Feats_Items_Feat
    {
        public GetFeatById_Feats_Items_Feat(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::System.String? special,
            global::System.String? trigger,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Frequency? frequency,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_RollableEffect? rollableEffect,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits> traits)
        {
            Id = id;
            Name = name;
            Level = level;
            Special = special;
            Trigger = trigger;
            Frequency = frequency;
            RollableEffect = rollableEffect;
            Traits = traits;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.String? Special { get; }

        public global::System.String? Trigger { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Frequency? Frequency { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_RollableEffect? RollableEffect { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits> Traits { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatById_Feats_Items_Feat)obj);
        }

        public global::System.Boolean Equals(GetFeatById_Feats_Items_Feat? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Level == other.Level
                && ((Special is null && other.Special is null) ||Special != null && Special.Equals(other.Special))
                && ((Trigger is null && other.Trigger is null) ||Trigger != null && Trigger.Equals(other.Trigger))
                && ((Frequency is null && other.Frequency is null) ||Frequency != null && Frequency.Equals(other.Frequency))
                && ((RollableEffect is null && other.RollableEffect is null) ||RollableEffect != null && RollableEffect.Equals(other.RollableEffect))
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Traits,
                        other.Traits);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Level.GetHashCode();

                if (!(Special is null))
                {
                    hash ^= 397 * Special.GetHashCode();
                }

                if (!(Trigger is null))
                {
                    hash ^= 397 * Trigger.GetHashCode();
                }

                if (!(Frequency is null))
                {
                    hash ^= 397 * Frequency.GetHashCode();
                }

                if (!(RollableEffect is null))
                {
                    hash ^= 397 * RollableEffect.GetHashCode();
                }

                foreach (var Traits_elm in Traits)
                {
                    hash ^= 397 * Traits_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, GetFeatById_Feats_Items_Frequency_Frequency>
    {
        public GetFeatById_Feats_Items_Frequency_Frequency Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetFeatById_Feats_Items_Frequency_Frequency(entity.Name);
        }
    }
}


// GetFeatById_Feats_Items_Frequency_Frequency.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_Frequency_Frequency
        : global::System.IEquatable<GetFeatById_Feats_Items_Frequency_Frequency>
        , IGetFeatById_Feats_Items_Frequency_Frequency
    {
        public GetFeatById_Feats_Items_Frequency_Frequency(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatById_Feats_Items_Frequency_Frequency)obj);
        }

        public global::System.Boolean Equals(GetFeatById_Feats_Items_Frequency_Frequency? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// GetFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, GetFeatById_Feats_Items_RollableEffect_RollableEffect>
    {
        public GetFeatById_Feats_Items_RollableEffect_RollableEffect Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetFeatById_Feats_Items_RollableEffect_RollableEffect(
                entity.CriticalSuccess,
                entity.Success,
                entity.Failure,
                entity.CriticalFailure);
        }
    }
}


// GetFeatById_Feats_Items_RollableEffect_RollableEffect.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_RollableEffect_RollableEffect
        : global::System.IEquatable<GetFeatById_Feats_Items_RollableEffect_RollableEffect>
        , IGetFeatById_Feats_Items_RollableEffect_RollableEffect
    {
        public GetFeatById_Feats_Items_RollableEffect_RollableEffect(
            global::System.String? criticalSuccess,
            global::System.String? success,
            global::System.String? failure,
            global::System.String? criticalFailure)
        {
            CriticalSuccess = criticalSuccess;
            Success = success;
            Failure = failure;
            CriticalFailure = criticalFailure;
        }

        public global::System.String? CriticalSuccess { get; }

        public global::System.String? Success { get; }

        public global::System.String? Failure { get; }

        public global::System.String? CriticalFailure { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatById_Feats_Items_RollableEffect_RollableEffect)obj);
        }

        public global::System.Boolean Equals(GetFeatById_Feats_Items_RollableEffect_RollableEffect? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((CriticalSuccess is null && other.CriticalSuccess is null) ||CriticalSuccess != null && CriticalSuccess.Equals(other.CriticalSuccess)))
                && ((Success is null && other.Success is null) ||Success != null && Success.Equals(other.Success))
                && ((Failure is null && other.Failure is null) ||Failure != null && Failure.Equals(other.Failure))
                && ((CriticalFailure is null && other.CriticalFailure is null) ||CriticalFailure != null && CriticalFailure.Equals(other.CriticalFailure));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(CriticalSuccess is null))
                {
                    hash ^= 397 * CriticalSuccess.GetHashCode();
                }

                if (!(Success is null))
                {
                    hash ^= 397 * Success.GetHashCode();
                }

                if (!(Failure is null))
                {
                    hash ^= 397 * Failure.GetHashCode();
                }

                if (!(CriticalFailure is null))
                {
                    hash ^= 397 * CriticalFailure.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetFeatById_Feats_Items_Traits_Trait>
    {
        public GetFeatById_Feats_Items_Traits_Trait Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetFeatById_Feats_Items_Traits_Trait(
                entity.Id,
                entity.Name,
                entity.Description);
        }
    }
}


// GetFeatById_Feats_Items_Traits_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatById_Feats_Items_Traits_Trait
        : global::System.IEquatable<GetFeatById_Feats_Items_Traits_Trait>
        , IGetFeatById_Feats_Items_Traits_Trait
    {
        public GetFeatById_Feats_Items_Traits_Trait(
            global::System.Guid id,
            global::System.String name,
            global::System.String description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatById_Feats_Items_Traits_Trait)obj);
        }

        public global::System.Boolean Equals(GetFeatById_Feats_Items_Traits_Trait? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Description.Equals(other.Description);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Description.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetFeatByIdResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatByIdResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats? Feats { get; }
    }
}


// IGetFeatById_Feats.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats
    {
        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items?>? Items { get; }
    }
}


// IGetFeatById_Feats_FeatCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_FeatCollectionSegment
        : IGetFeatById_Feats
    {
    }
}


// IFeatById.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IFeatById
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.String? Special { get; }

        public global::System.String? Trigger { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Frequency? Frequency { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_RollableEffect? RollableEffect { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatById_Feats_Items_Traits> Traits { get; }
    }
}


// IGetFeatById_Feats_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items
        : IFeatById
    {
    }
}


// IGetFeatById_Feats_Items_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_Feat
        : IGetFeatById_Feats_Items
    {
    }
}


// IGetFeatById_Feats_Items_Frequency.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_Frequency
    {
        public global::System.String Name { get; }
    }
}


// IGetFeatById_Feats_Items_Frequency_Frequency.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_Frequency_Frequency
        : IGetFeatById_Feats_Items_Frequency
    {
    }
}


// IGetFeatById_Feats_Items_RollableEffect.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_RollableEffect
    {
        public global::System.String? CriticalSuccess { get; }

        public global::System.String? Success { get; }

        public global::System.String? Failure { get; }

        public global::System.String? CriticalFailure { get; }
    }
}


// IGetFeatById_Feats_Items_RollableEffect_RollableEffect.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_RollableEffect_RollableEffect
        : IGetFeatById_Feats_Items_RollableEffect
    {
    }
}


// IFeatById_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IFeatById_Trait
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }
    }
}


// IGetFeatById_Feats_Items_Traits.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_Traits
        : IFeatById_Trait
    {
    }
}


// IGetFeatById_Feats_Items_Traits_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatById_Feats_Items_Traits_Trait
        : IGetFeatById_Feats_Items_Traits
    {
    }
}


// GetFeatsPageResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatsPage_Feats_Items_Feat> _getFeatsPage_Feats_Items_FeatFromFeatEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, GetFeatsPage_Feats_Items_Details_FeatDetailsBlock> _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper;

        public GetFeatsPageResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatsPage_Feats_Items_Feat> getFeatsPage_Feats_Items_FeatFromFeatEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, GetFeatsPage_Feats_Items_Details_FeatDetailsBlock> getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getFeatsPage_Feats_Items_FeatFromFeatEntityMapper = getFeatsPage_Feats_Items_FeatFromFeatEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatsPage_Feats_Items_FeatFromFeatEntityMapper));
            _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper = getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult);

        public GetFeatsPageResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetFeatsPageResultInfo info)
            {
                return new GetFeatsPageResult(MapIGetFeatsPage_Feats(
                    info.Feats,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetFeatsPageResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats? MapIGetFeatsPage_Feats(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetFeatsPage_Feats returnValue = default!;

            if (data?.__typename.Equals(
                    "FeatCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetFeatsPage_Feats_FeatCollectionSegment(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIGetFeatsPage_Feats_ItemsArray(
                        data.Items,
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items?>? MapIGetFeatsPage_Feats_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var feats = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                feats.Add(MapIGetFeatsPage_Feats_Items(
                    child,
                    snapshot));
            }

            return feats;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items? MapIGetFeatsPage_Feats_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatsPage_Feats_Items_FeatFromFeatEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details> MapNonNullableIGetFeatsPage_Feats_Items_DetailsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var featDetailsBlocks = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                featDetailsBlocks.Add(MapNonNullableIGetFeatsPage_Feats_Items_Details(
                    child,
                    snapshot));
            }

            return featDetailsBlocks;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details MapNonNullableIGetFeatsPage_Feats_Items_Details(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "FeatDetailsBlock",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetFeatsPageResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetFeatsPageResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? feats,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Feats = feats;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? Feats { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetFeatsPageResultInfo(
                Feats,
                _entityIds,
                version);
        }
    }
}


// GetFeatsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageResult
        : global::System.IEquatable<GetFeatsPageResult>
        , IGetFeatsPageResult
    {
        public GetFeatsPageResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats? feats)
        {
            Feats = feats;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats? Feats { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatsPageResult)obj);
        }

        public global::System.Boolean Equals(GetFeatsPageResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Feats is null && other.Feats is null) ||Feats != null && Feats.Equals(other.Feats)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Feats is null))
                {
                    hash ^= 397 * Feats.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetFeatsPage_Feats_FeatCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPage_Feats_FeatCollectionSegment
        : global::System.IEquatable<GetFeatsPage_Feats_FeatCollectionSegment>
        , IGetFeatsPage_Feats_FeatCollectionSegment
    {
        public GetFeatsPage_Feats_FeatCollectionSegment(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items?>? items)
        {
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatsPage_Feats_FeatCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetFeatsPage_Feats_FeatCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (TotalCount == other.TotalCount)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * TotalCount.GetHashCode();

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetFeatsPage_Feats_Items_FeatFromFeatEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPage_Feats_Items_FeatFromFeatEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetFeatsPage_Feats_Items_Feat>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, GetFeatsPage_Feats_Items_Details_FeatDetailsBlock> _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper;

        public GetFeatsPage_Feats_Items_FeatFromFeatEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, GetFeatsPage_Feats_Items_Details_FeatDetailsBlock> getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper = getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper));
        }

        public GetFeatsPage_Feats_Items_Feat Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetFeatsPage_Feats_Items_Feat(
                entity.Id,
                entity.Name,
                entity.Level,
                entity.CanBeLearnedMoreThanOnce,
                MapNonNullableIGetFeatsPage_Feats_Items_DetailsNonNullableArray(
                    entity.Details,
                    snapshot));
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details> MapNonNullableIGetFeatsPage_Feats_Items_DetailsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var featDetailsBlocks = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                featDetailsBlocks.Add(MapNonNullableIGetFeatsPage_Feats_Items_Details(
                    child,
                    snapshot));
            }

            return featDetailsBlocks;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details MapNonNullableIGetFeatsPage_Feats_Items_Details(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "FeatDetailsBlock",
                    global::System.StringComparison.Ordinal))
            {
                return _getFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetFeatsPage_Feats_Items_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPage_Feats_Items_Feat
        : global::System.IEquatable<GetFeatsPage_Feats_Items_Feat>
        , IGetFeatsPage_Feats_Items_Feat
    {
        public GetFeatsPage_Feats_Items_Feat(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::System.Boolean canBeLearnedMoreThanOnce,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details> details)
        {
            Id = id;
            Name = name;
            Level = level;
            CanBeLearnedMoreThanOnce = canBeLearnedMoreThanOnce;
            Details = details;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.Boolean CanBeLearnedMoreThanOnce { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details> Details { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatsPage_Feats_Items_Feat)obj);
        }

        public global::System.Boolean Equals(GetFeatsPage_Feats_Items_Feat? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Level == other.Level
                && CanBeLearnedMoreThanOnce == other.CanBeLearnedMoreThanOnce
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Details,
                        other.Details);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Level.GetHashCode();

                hash ^= 397 * CanBeLearnedMoreThanOnce.GetHashCode();

                foreach (var Details_elm in Details)
                {
                    hash ^= 397 * Details_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, GetFeatsPage_Feats_Items_Details_FeatDetailsBlock>
    {
        public GetFeatsPage_Feats_Items_Details_FeatDetailsBlock Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetFeatsPage_Feats_Items_Details_FeatDetailsBlock(entity.Text);
        }
    }
}


// GetFeatsPage_Feats_Items_Details_FeatDetailsBlock.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPage_Feats_Items_Details_FeatDetailsBlock
        : global::System.IEquatable<GetFeatsPage_Feats_Items_Details_FeatDetailsBlock>
        , IGetFeatsPage_Feats_Items_Details_FeatDetailsBlock
    {
        public GetFeatsPage_Feats_Items_Details_FeatDetailsBlock(global::System.String text)
        {
            Text = text;
        }

        public global::System.String Text { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetFeatsPage_Feats_Items_Details_FeatDetailsBlock)obj);
        }

        public global::System.Boolean Equals(GetFeatsPage_Feats_Items_Details_FeatDetailsBlock? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Text.Equals(other.Text));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Text.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetFeatsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPageResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats? Feats { get; }
    }
}


// IGetFeatsPage_Feats.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats
    {
        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items?>? Items { get; }
    }
}


// IGetFeatsPage_Feats_FeatCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats_FeatCollectionSegment
        : IGetFeatsPage_Feats
    {
    }
}


// IFeatsPage.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IFeatsPage
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.Boolean CanBeLearnedMoreThanOnce { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPage_Feats_Items_Details> Details { get; }
    }
}


// IGetFeatsPage_Feats_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats_Items
        : IFeatsPage
    {
    }
}


// IGetFeatsPage_Feats_Items_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats_Items_Feat
        : IGetFeatsPage_Feats_Items
    {
    }
}


// IGetFeatsPage_Feats_Items_Details.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats_Items_Details
    {
        public global::System.String Text { get; }
    }
}


// IGetFeatsPage_Feats_Items_Details_FeatDetailsBlock.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetFeatsPage_Feats_Items_Details_FeatDetailsBlock
        : IGetFeatsPage_Feats_Items_Details
    {
    }
}


// GetRacesPageResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity, GetRacesPage_Races_Items_Race> _getRacesPage_Races_Items_RaceFromRaceEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, GetRacesPage_Races_Items_Size_RaceSize> _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, GetRacesPage_Races_Items_Rarity_RaceRarity> _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper;

        public GetRacesPageResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity, GetRacesPage_Races_Items_Race> getRacesPage_Races_Items_RaceFromRaceEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, GetRacesPage_Races_Items_Size_RaceSize> getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, GetRacesPage_Races_Items_Rarity_RaceRarity> getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getRacesPage_Races_Items_RaceFromRaceEntityMapper = getRacesPage_Races_Items_RaceFromRaceEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage_Races_Items_RaceFromRaceEntityMapper));
            _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper = getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper));
            _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper = getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult);

        public GetRacesPageResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetRacesPageResultInfo info)
            {
                return new GetRacesPageResult(MapIGetRacesPage_Races(
                    info.Races,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetRacesPageResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races? MapIGetRacesPage_Races(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetRacesPage_Races returnValue = default!;

            if (data?.__typename.Equals(
                    "RaceCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetRacesPage_Races_RaceCollectionSegment(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIGetRacesPage_Races_ItemsArray(
                        data.Items,
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items?>? MapIGetRacesPage_Races_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var races = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                races.Add(MapIGetRacesPage_Races_Items(
                    child,
                    snapshot));
            }

            return races;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items? MapIGetRacesPage_Races_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Race",
                    global::System.StringComparison.Ordinal))
            {
                return _getRacesPage_Races_Items_RaceFromRaceEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Size MapNonNullableIGetRacesPage_Races_Items_Size(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RaceSize",
                    global::System.StringComparison.Ordinal))
            {
                return _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Rarity MapNonNullableIGetRacesPage_Races_Items_Rarity(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RaceRarity",
                    global::System.StringComparison.Ordinal))
            {
                return _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetRacesPageResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetRacesPageResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData? races,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Races = races;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData? Races { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetRacesPageResultInfo(
                Races,
                _entityIds,
                version);
        }
    }
}


// GetRacesPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageResult
        : global::System.IEquatable<GetRacesPageResult>
        , IGetRacesPageResult
    {
        public GetRacesPageResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races? races)
        {
            Races = races;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races? Races { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetRacesPageResult)obj);
        }

        public global::System.Boolean Equals(GetRacesPageResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Races is null && other.Races is null) ||Races != null && Races.Equals(other.Races)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Races is null))
                {
                    hash ^= 397 * Races.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetRacesPage_Races_RaceCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_RaceCollectionSegment
        : global::System.IEquatable<GetRacesPage_Races_RaceCollectionSegment>
        , IGetRacesPage_Races_RaceCollectionSegment
    {
        public GetRacesPage_Races_RaceCollectionSegment(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items?>? items)
        {
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetRacesPage_Races_RaceCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetRacesPage_Races_RaceCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (TotalCount == other.TotalCount)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * TotalCount.GetHashCode();

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetRacesPage_Races_Items_RaceFromRaceEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_RaceFromRaceEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity, GetRacesPage_Races_Items_Race>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, GetRacesPage_Races_Items_Size_RaceSize> _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, GetRacesPage_Races_Items_Rarity_RaceRarity> _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper;

        public GetRacesPage_Races_Items_RaceFromRaceEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, GetRacesPage_Races_Items_Size_RaceSize> getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, GetRacesPage_Races_Items_Rarity_RaceRarity> getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper = getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper));
            _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper = getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper));
        }

        public GetRacesPage_Races_Items_Race Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetRacesPage_Races_Items_Race(
                entity.Id,
                entity.Name,
                entity.BaseSpeed,
                entity.BaseHealth,
                MapNonNullableIGetRacesPage_Races_Items_Size(
                    entity.Size,
                    snapshot),
                MapNonNullableIGetRacesPage_Races_Items_Rarity(
                    entity.Rarity,
                    snapshot));
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Size MapNonNullableIGetRacesPage_Races_Items_Size(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RaceSize",
                    global::System.StringComparison.Ordinal))
            {
                return _getRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Rarity MapNonNullableIGetRacesPage_Races_Items_Rarity(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "RaceRarity",
                    global::System.StringComparison.Ordinal))
            {
                return _getRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetRacesPage_Races_Items_Race.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_Race
        : global::System.IEquatable<GetRacesPage_Races_Items_Race>
        , IGetRacesPage_Races_Items_Race
    {
        public GetRacesPage_Races_Items_Race(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 baseSpeed,
            global::System.Int32 baseHealth,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Size size,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Rarity rarity)
        {
            Id = id;
            Name = name;
            BaseSpeed = baseSpeed;
            BaseHealth = baseHealth;
            Size = size;
            Rarity = rarity;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 BaseSpeed { get; }

        public global::System.Int32 BaseHealth { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Size Size { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Rarity Rarity { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetRacesPage_Races_Items_Race)obj);
        }

        public global::System.Boolean Equals(GetRacesPage_Races_Items_Race? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && BaseSpeed == other.BaseSpeed
                && BaseHealth == other.BaseHealth
                && Size.Equals(other.Size)
                && Rarity.Equals(other.Rarity);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * BaseSpeed.GetHashCode();

                hash ^= 397 * BaseHealth.GetHashCode();

                hash ^= 397 * Size.GetHashCode();

                hash ^= 397 * Rarity.GetHashCode();

                return hash;
            }
        }
    }
}


// GetRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, GetRacesPage_Races_Items_Size_RaceSize>
    {
        public GetRacesPage_Races_Items_Size_RaceSize Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetRacesPage_Races_Items_Size_RaceSize(entity.Name);
        }
    }
}


// GetRacesPage_Races_Items_Size_RaceSize.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_Size_RaceSize
        : global::System.IEquatable<GetRacesPage_Races_Items_Size_RaceSize>
        , IGetRacesPage_Races_Items_Size_RaceSize
    {
        public GetRacesPage_Races_Items_Size_RaceSize(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetRacesPage_Races_Items_Size_RaceSize)obj);
        }

        public global::System.Boolean Equals(GetRacesPage_Races_Items_Size_RaceSize? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// GetRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, GetRacesPage_Races_Items_Rarity_RaceRarity>
    {
        public GetRacesPage_Races_Items_Rarity_RaceRarity Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetRacesPage_Races_Items_Rarity_RaceRarity(entity.Name);
        }
    }
}


// GetRacesPage_Races_Items_Rarity_RaceRarity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPage_Races_Items_Rarity_RaceRarity
        : global::System.IEquatable<GetRacesPage_Races_Items_Rarity_RaceRarity>
        , IGetRacesPage_Races_Items_Rarity_RaceRarity
    {
        public GetRacesPage_Races_Items_Rarity_RaceRarity(global::System.String name)
        {
            Name = name;
        }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetRacesPage_Races_Items_Rarity_RaceRarity)obj);
        }

        public global::System.Boolean Equals(GetRacesPage_Races_Items_Rarity_RaceRarity? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Name.Equals(other.Name));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetRacesPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPageResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races? Races { get; }
    }
}


// IGetRacesPage_Races.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races
    {
        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items?>? Items { get; }
    }
}


// IGetRacesPage_Races_RaceCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_RaceCollectionSegment
        : IGetRacesPage_Races
    {
    }
}


// IRacesPage.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IRacesPage
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 BaseSpeed { get; }

        public global::System.Int32 BaseHealth { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Size Size { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPage_Races_Items_Rarity Rarity { get; }
    }
}


// IGetRacesPage_Races_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items
        : IRacesPage
    {
    }
}


// IGetRacesPage_Races_Items_Race.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items_Race
        : IGetRacesPage_Races_Items
    {
    }
}


// IRacesPage_Size.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IRacesPage_Size
    {
        public global::System.String Name { get; }
    }
}


// IGetRacesPage_Races_Items_Size.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items_Size
        : IRacesPage_Size
    {
    }
}


// IGetRacesPage_Races_Items_Size_RaceSize.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items_Size_RaceSize
        : IGetRacesPage_Races_Items_Size
    {
    }
}


// IRacesPage_Rarity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IRacesPage_Rarity
    {
        public global::System.String Name { get; }
    }
}


// IGetRacesPage_Races_Items_Rarity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items_Rarity
        : IRacesPage_Rarity
    {
    }
}


// IGetRacesPage_Races_Items_Rarity_RaceRarity.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetRacesPage_Races_Items_Rarity_RaceRarity
        : IGetRacesPage_Races_Items_Rarity
    {
    }
}


// GetSpellsPageResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetSpellsPage_Spells_Items_Spell> _getSpellsPage_Spells_Items_SpellFromSpellEntityMapper;

        public GetSpellsPageResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetSpellsPage_Spells_Items_Spell> getSpellsPage_Spells_Items_SpellFromSpellEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getSpellsPage_Spells_Items_SpellFromSpellEntityMapper = getSpellsPage_Spells_Items_SpellFromSpellEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getSpellsPage_Spells_Items_SpellFromSpellEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult);

        public GetSpellsPageResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetSpellsPageResultInfo info)
            {
                return new GetSpellsPageResult(MapIGetSpellsPage_Spells(
                    info.Spells,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetSpellsPageResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells? MapIGetSpellsPage_Spells(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetSpellsPage_Spells returnValue = default!;

            if (data?.__typename.Equals(
                    "SpellCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetSpellsPage_Spells_SpellCollectionSegment(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIGetSpellsPage_Spells_ItemsArray(
                        data.Items,
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items?>? MapIGetSpellsPage_Spells_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var spells = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                spells.Add(MapIGetSpellsPage_Spells_Items(
                    child,
                    snapshot));
            }

            return spells;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items? MapIGetSpellsPage_Spells_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Spell",
                    global::System.StringComparison.Ordinal))
            {
                return _getSpellsPage_Spells_Items_SpellFromSpellEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetSpellsPageResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetSpellsPageResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData? spells,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Spells = spells;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData? Spells { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetSpellsPageResultInfo(
                Spells,
                _entityIds,
                version);
        }
    }
}


// GetSpellsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageResult
        : global::System.IEquatable<GetSpellsPageResult>
        , IGetSpellsPageResult
    {
        public GetSpellsPageResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells? spells)
        {
            Spells = spells;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells? Spells { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSpellsPageResult)obj);
        }

        public global::System.Boolean Equals(GetSpellsPageResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Spells is null && other.Spells is null) ||Spells != null && Spells.Equals(other.Spells)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Spells is null))
                {
                    hash ^= 397 * Spells.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetSpellsPage_Spells_SpellCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPage_Spells_SpellCollectionSegment
        : global::System.IEquatable<GetSpellsPage_Spells_SpellCollectionSegment>
        , IGetSpellsPage_Spells_SpellCollectionSegment
    {
        public GetSpellsPage_Spells_SpellCollectionSegment(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items?>? items)
        {
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSpellsPage_Spells_SpellCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetSpellsPage_Spells_SpellCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (TotalCount == other.TotalCount)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * TotalCount.GetHashCode();

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetSpellsPage_Spells_Items_SpellFromSpellEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPage_Spells_Items_SpellFromSpellEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetSpellsPage_Spells_Items_Spell>
    {
        public GetSpellsPage_Spells_Items_Spell Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetSpellsPage_Spells_Items_Spell(
                entity.Id,
                entity.Name,
                entity.Level);
        }
    }
}


// GetSpellsPage_Spells_Items_Spell.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPage_Spells_Items_Spell
        : global::System.IEquatable<GetSpellsPage_Spells_Items_Spell>
        , IGetSpellsPage_Spells_Items_Spell
    {
        public GetSpellsPage_Spells_Items_Spell(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level)
        {
            Id = id;
            Name = name;
            Level = level;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetSpellsPage_Spells_Items_Spell)obj);
        }

        public global::System.Boolean Equals(GetSpellsPage_Spells_Items_Spell? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Level == other.Level;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Level.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetSpellsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSpellsPageResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells? Spells { get; }
    }
}


// IGetSpellsPage_Spells.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSpellsPage_Spells
    {
        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPage_Spells_Items?>? Items { get; }
    }
}


// IGetSpellsPage_Spells_SpellCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSpellsPage_Spells_SpellCollectionSegment
        : IGetSpellsPage_Spells
    {
    }
}


// IGetSpellsPage_Spells_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSpellsPage_Spells_Items
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }
    }
}


// IGetSpellsPage_Spells_Items_Spell.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetSpellsPage_Spells_Items_Spell
        : IGetSpellsPage_Spells_Items
    {
    }
}


// GetTraitByIdResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitById_Traits_Items_Trait> _getTraitById_Traits_Items_TraitFromTraitEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetTraitById_Traits_Items_Feats_Feat> _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetTraitById_Traits_Items_Spells_Spell> _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper;

        public GetTraitByIdResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitById_Traits_Items_Trait> getTraitById_Traits_Items_TraitFromTraitEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetTraitById_Traits_Items_Feats_Feat> getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetTraitById_Traits_Items_Spells_Spell> getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getTraitById_Traits_Items_TraitFromTraitEntityMapper = getTraitById_Traits_Items_TraitFromTraitEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_TraitFromTraitEntityMapper));
            _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper = getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper));
            _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper = getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper));
            _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper = getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper));
            _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper = getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult);

        public GetTraitByIdResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetTraitByIdResultInfo info)
            {
                return new GetTraitByIdResult(MapIGetTraitById_Traits(
                    info.Traits,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetTraitByIdResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits? MapIGetTraitById_Traits(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetTraitById_Traits returnValue = default!;

            if (data?.__typename.Equals(
                    "TraitCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetTraitById_Traits_TraitCollectionSegment(MapIGetTraitById_Traits_ItemsArray(
                    data.Items,
                    snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items?>? MapIGetTraitById_Traits_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var traits = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                traits.Add(MapIGetTraitById_Traits_Items(
                    child,
                    snapshot));
            }

            return traits;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items? MapIGetTraitById_Traits_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_TraitFromTraitEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats> MapNonNullableIGetTraitById_Traits_Items_FeatsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var feats = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                feats.Add(MapNonNullableIGetTraitById_Traits_Items_Feats(
                    child,
                    snapshot));
            }

            return feats;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats MapNonNullableIGetTraitById_Traits_Items_Feats(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells> MapNonNullableIGetTraitById_Traits_Items_SpellsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var spells = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                spells.Add(MapNonNullableIGetTraitById_Traits_Items_Spells(
                    child,
                    snapshot));
            }

            return spells;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells MapNonNullableIGetTraitById_Traits_Items_Spells(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Spell",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool MapNonNullableIGetTraitById_Traits_Items_Spells_MagicSchool(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "MagicSchool",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType MapNonNullableIGetTraitById_Traits_Items_Spells_SpellType(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "SpellType",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetTraitByIdResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetTraitByIdResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? traits,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Traits = traits;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? Traits { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetTraitByIdResultInfo(
                Traits,
                _entityIds,
                version);
        }
    }
}


// GetTraitByIdResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdResult
        : global::System.IEquatable<GetTraitByIdResult>
        , IGetTraitByIdResult
    {
        public GetTraitByIdResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits? traits)
        {
            Traits = traits;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits? Traits { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitByIdResult)obj);
        }

        public global::System.Boolean Equals(GetTraitByIdResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Traits is null && other.Traits is null) ||Traits != null && Traits.Equals(other.Traits)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Traits is null))
                {
                    hash ^= 397 * Traits.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_TraitCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_TraitCollectionSegment
        : global::System.IEquatable<GetTraitById_Traits_TraitCollectionSegment>
        , IGetTraitById_Traits_TraitCollectionSegment
    {
        public GetTraitById_Traits_TraitCollectionSegment(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items?>? items)
        {
            Items = items;
        }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_TraitCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_TraitCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_Items_TraitFromTraitEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_TraitFromTraitEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitById_Traits_Items_Trait>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetTraitById_Traits_Items_Feats_Feat> _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetTraitById_Traits_Items_Spells_Spell> _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper;

        public GetTraitById_Traits_Items_TraitFromTraitEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetTraitById_Traits_Items_Feats_Feat> getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetTraitById_Traits_Items_Spells_Spell> getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper = getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper));
            _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper = getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper));
            _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper = getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper));
            _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper = getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper));
        }

        public GetTraitById_Traits_Items_Trait Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetTraitById_Traits_Items_Trait(
                entity.Id,
                entity.Name,
                entity.Description,
                MapNonNullableIGetTraitById_Traits_Items_FeatsNonNullableArray(
                    entity.Feats,
                    snapshot),
                MapNonNullableIGetTraitById_Traits_Items_SpellsNonNullableArray(
                    entity.Spells,
                    snapshot));
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats> MapNonNullableIGetTraitById_Traits_Items_FeatsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var feats = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                feats.Add(MapNonNullableIGetTraitById_Traits_Items_Feats(
                    child,
                    snapshot));
            }

            return feats;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats MapNonNullableIGetTraitById_Traits_Items_Feats(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells> MapNonNullableIGetTraitById_Traits_Items_SpellsNonNullableArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            var spells = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells>();

            foreach (global::StrawberryShake.EntityId child in list)
            {
                spells.Add(MapNonNullableIGetTraitById_Traits_Items_Spells(
                    child,
                    snapshot));
            }

            return spells;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells MapNonNullableIGetTraitById_Traits_Items_Spells(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "Spell",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool MapNonNullableIGetTraitById_Traits_Items_Spells_MagicSchool(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "MagicSchool",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType MapNonNullableIGetTraitById_Traits_Items_Spells_SpellType(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "SpellType",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetTraitById_Traits_Items_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Trait
        : global::System.IEquatable<GetTraitById_Traits_Items_Trait>
        , IGetTraitById_Traits_Items_Trait
    {
        public GetTraitById_Traits_Items_Trait(
            global::System.Guid id,
            global::System.String name,
            global::System.String description,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats> feats,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells> spells)
        {
            Id = id;
            Name = name;
            Description = description;
            Feats = feats;
            Spells = spells;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats> Feats { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells> Spells { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_Items_Trait)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_Items_Trait? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Description.Equals(other.Description)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Feats,
                        other.Feats)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Spells,
                        other.Spells);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Description.GetHashCode();

                foreach (var Feats_elm in Feats)
                {
                    hash ^= 397 * Feats_elm.GetHashCode();
                }

                foreach (var Spells_elm in Spells)
                {
                    hash ^= 397 * Spells_elm.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, GetTraitById_Traits_Items_Feats_Feat>
    {
        public GetTraitById_Traits_Items_Feats_Feat Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetTraitById_Traits_Items_Feats_Feat(
                entity.Id,
                entity.Name,
                entity.Level,
                entity.CanBeLearnedMoreThanOnce);
        }
    }
}


// GetTraitById_Traits_Items_Feats_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Feats_Feat
        : global::System.IEquatable<GetTraitById_Traits_Items_Feats_Feat>
        , IGetTraitById_Traits_Items_Feats_Feat
    {
        public GetTraitById_Traits_Items_Feats_Feat(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::System.Boolean canBeLearnedMoreThanOnce)
        {
            Id = id;
            Name = name;
            Level = level;
            CanBeLearnedMoreThanOnce = canBeLearnedMoreThanOnce;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.Boolean CanBeLearnedMoreThanOnce { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_Items_Feats_Feat)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_Items_Feats_Feat? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Level == other.Level
                && CanBeLearnedMoreThanOnce == other.CanBeLearnedMoreThanOnce;
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Level.GetHashCode();

                hash ^= 397 * CanBeLearnedMoreThanOnce.GetHashCode();

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, GetTraitById_Traits_Items_Spells_Spell>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper;

        public GetTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool> getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType> getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper = getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper));
            _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper = getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper));
        }

        public GetTraitById_Traits_Items_Spells_Spell Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            return new GetTraitById_Traits_Items_Spells_Spell(
                entity.Id,
                entity.Name,
                entity.Level,
                MapNonNullableIGetTraitById_Traits_Items_Spells_MagicSchool(
                    entity.MagicSchool,
                    snapshot),
                MapNonNullableIGetTraitById_Traits_Items_Spells_SpellType(
                    entity.SpellType,
                    snapshot));
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool MapNonNullableIGetTraitById_Traits_Items_Spells_MagicSchool(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "MagicSchool",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType MapNonNullableIGetTraitById_Traits_Items_Spells_SpellType(
            global::StrawberryShake.EntityId entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {

            if (entityId.Name.Equals(
                    "SpellType",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity>(entityId)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }
    }
}


// GetTraitById_Traits_Items_Spells_Spell.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_Spell
        : global::System.IEquatable<GetTraitById_Traits_Items_Spells_Spell>
        , IGetTraitById_Traits_Items_Spells_Spell
    {
        public GetTraitById_Traits_Items_Spells_Spell(
            global::System.Guid id,
            global::System.String name,
            global::System.Int32 level,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool magicSchool,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType spellType)
        {
            Id = id;
            Name = name;
            Level = level;
            MagicSchool = magicSchool;
            SpellType = spellType;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool MagicSchool { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType SpellType { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_Items_Spells_Spell)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_Items_Spells_Spell? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Level == other.Level
                && MagicSchool.Equals(other.MagicSchool)
                && SpellType.Equals(other.SpellType);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Level.GetHashCode();

                hash ^= 397 * MagicSchool.GetHashCode();

                hash ^= 397 * SpellType.GetHashCode();

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool>
    {
        public GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool(
                entity.Id,
                entity.Name);
        }
    }
}


// GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool
        : global::System.IEquatable<GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool>
        , IGetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool
    {
        public GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool(
            global::System.Guid id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// GetTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, GetTraitById_Traits_Items_Spells_SpellType_SpellType>
    {
        public GetTraitById_Traits_Items_Spells_SpellType_SpellType Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetTraitById_Traits_Items_Spells_SpellType_SpellType(
                entity.Id,
                entity.Name);
        }
    }
}


// GetTraitById_Traits_Items_Spells_SpellType_SpellType.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitById_Traits_Items_Spells_SpellType_SpellType
        : global::System.IEquatable<GetTraitById_Traits_Items_Spells_SpellType_SpellType>
        , IGetTraitById_Traits_Items_Spells_SpellType_SpellType
    {
        public GetTraitById_Traits_Items_Spells_SpellType_SpellType(
            global::System.Guid id,
            global::System.String name)
        {
            Id = id;
            Name = name;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitById_Traits_Items_Spells_SpellType_SpellType)obj);
        }

        public global::System.Boolean Equals(GetTraitById_Traits_Items_Spells_SpellType_SpellType? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetTraitByIdResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitByIdResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits? Traits { get; }
    }
}


// IGetTraitById_Traits.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits
    {
        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items?>? Items { get; }
    }
}


// IGetTraitById_Traits_TraitCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_TraitCollectionSegment
        : IGetTraitById_Traits
    {
    }
}


// ITraitById.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitById
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Feats> Feats { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells> Spells { get; }
    }
}


// IGetTraitById_Traits_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items
        : ITraitById
    {
    }
}


// IGetTraitById_Traits_Items_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Trait
        : IGetTraitById_Traits_Items
    {
    }
}


// ITraitById_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitById_Feat
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::System.Boolean CanBeLearnedMoreThanOnce { get; }
    }
}


// IGetTraitById_Traits_Items_Feats.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Feats
        : ITraitById_Feat
    {
    }
}


// IGetTraitById_Traits_Items_Feats_Feat.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Feats_Feat
        : IGetTraitById_Traits_Items_Feats
    {
    }
}


// ITraitById_Spell.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitById_Spell
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.Int32 Level { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_MagicSchool MagicSchool { get; }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitById_Traits_Items_Spells_SpellType SpellType { get; }
    }
}


// IGetTraitById_Traits_Items_Spells.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells
        : ITraitById_Spell
    {
    }
}


// IGetTraitById_Traits_Items_Spells_Spell.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells_Spell
        : IGetTraitById_Traits_Items_Spells
    {
    }
}


// ITraitById_Spell_MagicSchool.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitById_Spell_MagicSchool
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }
    }
}


// IGetTraitById_Traits_Items_Spells_MagicSchool.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells_MagicSchool
        : ITraitById_Spell_MagicSchool
    {
    }
}


// IGetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool
        : IGetTraitById_Traits_Items_Spells_MagicSchool
    {
    }
}


// ITraitById_Spell_Type.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitById_Spell_Type
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }
    }
}


// IGetTraitById_Traits_Items_Spells_SpellType.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells_SpellType
        : ITraitById_Spell_Type
    {
    }
}


// IGetTraitById_Traits_Items_Spells_SpellType_SpellType.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitById_Traits_Items_Spells_SpellType_SpellType
        : IGetTraitById_Traits_Items_Spells_SpellType
    {
    }
}


// GetTraitsPageResultFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageResultFactory
        : global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitsPage_Traits_Items_Trait> _getTraitsPage_Traits_Items_TraitFromTraitEntityMapper;

        public GetTraitsPageResultFactory(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitsPage_Traits_Items_Trait> getTraitsPage_Traits_Items_TraitFromTraitEntityMapper)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _getTraitsPage_Traits_Items_TraitFromTraitEntityMapper = getTraitsPage_Traits_Items_TraitFromTraitEntityMapper
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitsPage_Traits_Items_TraitFromTraitEntityMapper));
        }

        global::System.Type global::StrawberryShake.IOperationResultDataFactory.ResultType => typeof(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult);

        public GetTraitsPageResult Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            if (snapshot is null)
            {
                snapshot = _entityStore.CurrentSnapshot;
            }

            if (dataInfo is GetTraitsPageResultInfo info)
            {
                return new GetTraitsPageResult(MapIGetTraitsPage_Traits(
                    info.Traits,
                    snapshot));
            }

            throw new global::System.ArgumentException("GetTraitsPageResultInfo expected.");
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits? MapIGetTraitsPage_Traits(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? data,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (data is null)
            {
                return null;
            }

            IGetTraitsPage_Traits returnValue = default!;

            if (data?.__typename.Equals(
                    "TraitCollectionSegment",
                    global::System.StringComparison.Ordinal) ?? false)
            {
                returnValue = new GetTraitsPage_Traits_TraitCollectionSegment(
                    data.TotalCount ?? throw new global::System.ArgumentNullException(),
                    MapIGetTraitsPage_Traits_ItemsArray(
                        data.Items,
                        snapshot));
            }
            else
            {
                throw new global::System.NotSupportedException();
            }
            return returnValue;
        }

        private global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items?>? MapIGetTraitsPage_Traits_ItemsArray(
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? list,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (list is null)
            {
                return null;
            }

            var traits = new global::System.Collections.Generic.List<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items?>();

            foreach (global::StrawberryShake.EntityId? child in list)
            {
                traits.Add(MapIGetTraitsPage_Traits_Items(
                    child,
                    snapshot));
            }

            return traits;
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items? MapIGetTraitsPage_Traits_Items(
            global::StrawberryShake.EntityId? entityId,
            global::StrawberryShake.IEntityStoreSnapshot snapshot)
        {
            if (entityId is null)
            {
                return null;
            }


            if (entityId.Value.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                return _getTraitsPage_Traits_Items_TraitFromTraitEntityMapper.Map(
                    snapshot.GetEntity<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity>(entityId.Value)
                        ?? throw new global::StrawberryShake.GraphQLClientException());
            }
            throw new global::System.NotSupportedException();
        }

        global::System.Object global::StrawberryShake.IOperationResultDataFactory.Create(
            global::StrawberryShake.IOperationResultDataInfo dataInfo,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot)
        {
            return Create(
                dataInfo,
                snapshot);
        }
    }
}


// GetTraitsPageResultInfo.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageResultInfo
        : global::StrawberryShake.IOperationResultDataInfo
    {
        private readonly global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> _entityIds;
        private readonly global::System.UInt64 _version;

        public GetTraitsPageResultInfo(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? traits,
            global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> entityIds,
            global::System.UInt64 version)
        {
            Traits = traits;
            _entityIds = entityIds
                 ?? throw new global::System.ArgumentNullException(nameof(entityIds));
            _version = version;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? Traits { get; }

        public global::System.Collections.Generic.IReadOnlyCollection<global::StrawberryShake.EntityId> EntityIds => _entityIds;

        public global::System.UInt64 Version => _version;

        public global::StrawberryShake.IOperationResultDataInfo WithVersion(global::System.UInt64 version)
        {
            return new GetTraitsPageResultInfo(
                Traits,
                _entityIds,
                version);
        }
    }
}


// GetTraitsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageResult
        : global::System.IEquatable<GetTraitsPageResult>
        , IGetTraitsPageResult
    {
        public GetTraitsPageResult(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits? traits)
        {
            Traits = traits;
        }

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits? Traits { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitsPageResult)obj);
        }

        public global::System.Boolean Equals(GetTraitsPageResult? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (((Traits is null && other.Traits is null) ||Traits != null && Traits.Equals(other.Traits)));
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                if (!(Traits is null))
                {
                    hash ^= 397 * Traits.GetHashCode();
                }

                return hash;
            }
        }
    }
}


// GetTraitsPage_Traits_TraitCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPage_Traits_TraitCollectionSegment
        : global::System.IEquatable<GetTraitsPage_Traits_TraitCollectionSegment>
        , IGetTraitsPage_Traits_TraitCollectionSegment
    {
        public GetTraitsPage_Traits_TraitCollectionSegment(
            global::System.Int32 totalCount,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items?>? items)
        {
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items?>? Items { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitsPage_Traits_TraitCollectionSegment)obj);
        }

        public global::System.Boolean Equals(GetTraitsPage_Traits_TraitCollectionSegment? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (TotalCount == other.TotalCount)
                && global::StrawberryShake.Helper.ComparisonHelper.SequenceEqual(
                        Items,
                        other.Items);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * TotalCount.GetHashCode();

                if (!(Items is null))
                {
                    foreach (var Items_elm in Items)
                    {
                        if (!(Items_elm is null))
                        {
                            hash ^= 397 * Items_elm.GetHashCode();
                        }
                    }
                }

                return hash;
            }
        }
    }
}


// GetTraitsPage_Traits_Items_TraitFromTraitEntityMapper.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPage_Traits_Items_TraitFromTraitEntityMapper
        : global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, GetTraitsPage_Traits_Items_Trait>
    {
        public GetTraitsPage_Traits_Items_Trait Map(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity entity,
            global::StrawberryShake.IEntityStoreSnapshot? snapshot = null)
        {
            return new GetTraitsPage_Traits_Items_Trait(
                entity.Id,
                entity.Name,
                entity.Description);
        }
    }
}


// GetTraitsPage_Traits_Items_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPage_Traits_Items_Trait
        : global::System.IEquatable<GetTraitsPage_Traits_Items_Trait>
        , IGetTraitsPage_Traits_Items_Trait
    {
        public GetTraitsPage_Traits_Items_Trait(
            global::System.Guid id,
            global::System.String name,
            global::System.String description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }

        public override global::System.Boolean Equals(global::System.Object? obj)
        {
            if (ReferenceEquals(
                    null,
                    obj))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    obj))
            {
                return true;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }

            return Equals((GetTraitsPage_Traits_Items_Trait)obj);
        }

        public global::System.Boolean Equals(GetTraitsPage_Traits_Items_Trait? other)
        {
            if (ReferenceEquals(
                    null,
                    other))
            {
                return false;
            }

            if (ReferenceEquals(
                    this,
                    other))
            {
                return true;
            }

            if (other.GetType() != GetType())
            {
                return false;
            }

            return (Id == other.Id)
                && Name.Equals(other.Name)
                && Description.Equals(other.Description);
        }

        public override global::System.Int32 GetHashCode()
        {
            unchecked
            {
                int hash = 5;

                hash ^= 397 * Id.GetHashCode();

                hash ^= 397 * Name.GetHashCode();

                hash ^= 397 * Description.GetHashCode();

                return hash;
            }
        }
    }
}


// IGetTraitsPageResult.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitsPageResult
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits? Traits { get; }
    }
}


// IGetTraitsPage_Traits.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitsPage_Traits
    {
        public global::System.Int32 TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPage_Traits_Items?>? Items { get; }
    }
}


// IGetTraitsPage_Traits_TraitCollectionSegment.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitsPage_Traits_TraitCollectionSegment
        : IGetTraitsPage_Traits
    {
    }
}


// ITraitsPage.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface ITraitsPage
    {
        public global::System.Guid Id { get; }

        public global::System.String Name { get; }

        public global::System.String Description { get; }
    }
}


// IGetTraitsPage_Traits_Items.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitsPage_Traits_Items
        : ITraitsPage
    {
    }
}


// IGetTraitsPage_Traits_Items_Trait.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public interface IGetTraitsPage_Traits_Items_Trait
        : IGetTraitsPage_Traits_Items
    {
    }
}


// FeatSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _actionTypeSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _featTypeSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _frequencySortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _rollableEffectSortInputFormatter = default!;

        public global::System.String TypeName => "FeatSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
            _actionTypeSortInputFormatter = serializerResolver.GetInputValueFormatter("ActionTypeSortInput");
            _featTypeSortInputFormatter = serializerResolver.GetInputValueFormatter("FeatTypeSortInput");
            _frequencySortInputFormatter = serializerResolver.GetInputValueFormatter("FrequencySortInput");
            _rollableEffectSortInputFormatter = serializerResolver.GetInputValueFormatter("RollableEffectSortInput");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is FeatSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "canBeLearnedMoreThanOnce",
                    FormatCanBeLearnedMoreThanOnce(d.CanBeLearnedMoreThanOnce)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "special",
                    FormatSpecial(d.Special)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "trigger",
                    FormatTrigger(d.Trigger)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "level",
                    FormatLevel(d.Level)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "actionTypeId",
                    FormatActionTypeId(d.ActionTypeId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "actionType",
                    FormatActionType(d.ActionType)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "featTypeId",
                    FormatFeatTypeId(d.FeatTypeId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "featType",
                    FormatFeatType(d.FeatType)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "frequencyId",
                    FormatFrequencyId(d.FrequencyId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "frequency",
                    FormatFrequency(d.Frequency)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rollableEffect",
                    FormatRollableEffect(d.RollableEffect)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rollableEffectId",
                    FormatRollableEffectId(d.RollableEffectId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatCanBeLearnedMoreThanOnce(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSpecial(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatTrigger(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatLevel(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatActionTypeId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatActionType(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.ActionTypeSortInput? value)
        {
            return _actionTypeSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatFeatTypeId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatFeatType(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatTypeSortInput? value)
        {
            return _featTypeSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatFrequencyId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatFrequency(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FrequencySortInput? value)
        {
            return _frequencySortInputFormatter.Format(value);
        }

        private global::System.Object? FormatRollableEffect(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RollableEffectSortInput? value)
        {
            return _rollableEffectSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatRollableEffectId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// FeatSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? CanBeLearnedMoreThanOnce { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Special { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Trigger { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Level { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? ActionTypeId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.ActionTypeSortInput? ActionType { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? FeatTypeId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatTypeSortInput? FeatType { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? FrequencyId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FrequencySortInput? Frequency { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RollableEffectSortInput? RollableEffect { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? RollableEffectId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// ActionTypeSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ActionTypeSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "ActionTypeSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is ActionTypeSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// ActionTypeSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class ActionTypeSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// FeatTypeSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatTypeSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "FeatTypeSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is FeatTypeSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// FeatTypeSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatTypeSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// FrequencySortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FrequencySortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "FrequencySortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is FrequencySortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "amount",
                    FormatAmount(d.Amount)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "timeSpan",
                    FormatTimeSpan(d.TimeSpan)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatAmount(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatTimeSpan(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// FrequencySortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FrequencySortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Amount { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? TimeSpan { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// RollableEffectSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RollableEffectSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "RollableEffectSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is RollableEffectSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "criticalSuccess",
                    FormatCriticalSuccess(d.CriticalSuccess)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "success",
                    FormatSuccess(d.Success)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "failure",
                    FormatFailure(d.Failure)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "criticalFailure",
                    FormatCriticalFailure(d.CriticalFailure)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatCriticalSuccess(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSuccess(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatFailure(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatCriticalFailure(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// RollableEffectSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RollableEffectSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? CriticalSuccess { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Success { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Failure { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? CriticalFailure { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// RaceSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _raceSizeSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _raceRaritySortInputFormatter = default!;

        public global::System.String TypeName => "RaceSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
            _raceSizeSortInputFormatter = serializerResolver.GetInputValueFormatter("RaceSizeSortInput");
            _raceRaritySortInputFormatter = serializerResolver.GetInputValueFormatter("RaceRaritySortInput");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is RaceSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "baseSpeed",
                    FormatBaseSpeed(d.BaseSpeed)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "baseHealth",
                    FormatBaseHealth(d.BaseHealth)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "sizeId",
                    FormatSizeId(d.SizeId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "size",
                    FormatSize(d.Size)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rarityId",
                    FormatRarityId(d.RarityId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rarity",
                    FormatRarity(d.Rarity)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatBaseSpeed(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatBaseHealth(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSizeId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSize(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSizeSortInput? value)
        {
            return _raceSizeSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatRarityId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatRarity(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceRaritySortInput? value)
        {
            return _raceRaritySortInputFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// RaceSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? BaseSpeed { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? BaseHealth { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? SizeId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSizeSortInput? Size { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? RarityId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceRaritySortInput? Rarity { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// RaceSizeSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceSizeSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "RaceSizeSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is RaceSizeSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "space",
                    FormatSpace(d.Space)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "heightReach",
                    FormatHeightReach(d.HeightReach)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "breadthReach",
                    FormatBreadthReach(d.BreadthReach)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSpace(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatHeightReach(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatBreadthReach(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// RaceSizeSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceSizeSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Space { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? HeightReach { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? BreadthReach { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// RaceRaritySortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceRaritySortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "RaceRaritySortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is RaceRaritySortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// RaceRaritySortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceRaritySortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// SpellSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _actionTypeSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _spellTypeSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _savingThrowStatSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _rollableEffectSortInputFormatter = default!;
        private global::StrawberryShake.Serialization.IInputValueFormatter _magicSchoolSortInputFormatter = default!;

        public global::System.String TypeName => "SpellSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
            _actionTypeSortInputFormatter = serializerResolver.GetInputValueFormatter("ActionTypeSortInput");
            _spellTypeSortInputFormatter = serializerResolver.GetInputValueFormatter("SpellTypeSortInput");
            _savingThrowStatSortInputFormatter = serializerResolver.GetInputValueFormatter("SavingThrowStatSortInput");
            _rollableEffectSortInputFormatter = serializerResolver.GetInputValueFormatter("RollableEffectSortInput");
            _magicSchoolSortInputFormatter = serializerResolver.GetInputValueFormatter("MagicSchoolSortInput");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is SpellSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "description",
                    FormatDescription(d.Description)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "range",
                    FormatRange(d.Range)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "castTime",
                    FormatCastTime(d.CastTime)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "level",
                    FormatLevel(d.Level)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "targets",
                    FormatTargets(d.Targets)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "isDismissable",
                    FormatIsDismissable(d.IsDismissable)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "area",
                    FormatArea(d.Area)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "duration",
                    FormatDuration(d.Duration)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "actionTypeId",
                    FormatActionTypeId(d.ActionTypeId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "actionType",
                    FormatActionType(d.ActionType)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "spellTypeId",
                    FormatSpellTypeId(d.SpellTypeId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "spellType",
                    FormatSpellType(d.SpellType)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "savingThrowStatId",
                    FormatSavingThrowStatId(d.SavingThrowStatId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "savingThrowStat",
                    FormatSavingThrowStat(d.SavingThrowStat)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rollableEffect",
                    FormatRollableEffect(d.RollableEffect)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "rollableEffectId",
                    FormatRollableEffectId(d.RollableEffectId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "magicSchool",
                    FormatMagicSchool(d.MagicSchool)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "magicSchoolId",
                    FormatMagicSchoolId(d.MagicSchoolId)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatDescription(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatRange(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatCastTime(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatLevel(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatTargets(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatIsDismissable(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatArea(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatDuration(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatActionTypeId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatActionType(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.ActionTypeSortInput? value)
        {
            return _actionTypeSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatSpellTypeId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSpellType(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellTypeSortInput? value)
        {
            return _spellTypeSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatSavingThrowStatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatSavingThrowStat(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SavingThrowStatSortInput? value)
        {
            return _savingThrowStatSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatRollableEffect(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RollableEffectSortInput? value)
        {
            return _rollableEffectSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatRollableEffectId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatMagicSchool(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.MagicSchoolSortInput? value)
        {
            return _magicSchoolSortInputFormatter.Format(value);
        }

        private global::System.Object? FormatMagicSchoolId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// SpellSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Description { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Range { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? CastTime { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Level { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Targets { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? IsDismissable { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Area { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Duration { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? ActionTypeId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.ActionTypeSortInput? ActionType { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? SpellTypeId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellTypeSortInput? SpellType { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? SavingThrowStatId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SavingThrowStatSortInput? SavingThrowStat { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RollableEffectSortInput? RollableEffect { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? RollableEffectId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.MagicSchoolSortInput? MagicSchool { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? MagicSchoolId { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// SpellTypeSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellTypeSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "SpellTypeSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is SpellTypeSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "description",
                    FormatDescription(d.Description)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatDescription(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// SpellTypeSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellTypeSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Description { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// SavingThrowStatSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SavingThrowStatSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "SavingThrowStatSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is SavingThrowStatSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// SavingThrowStatSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SavingThrowStatSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// MagicSchoolSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class MagicSchoolSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "MagicSchoolSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is MagicSchoolSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "abbreviation",
                    FormatAbbreviation(d.Abbreviation)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "description",
                    FormatDescription(d.Description)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatAbbreviation(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatDescription(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// MagicSchoolSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class MagicSchoolSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Abbreviation { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Description { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// TraitSortInputInputValueFormatter.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class TraitSortInputInputValueFormatter
        : global::StrawberryShake.Serialization.IInputObjectFormatter
    {
        private global::StrawberryShake.Serialization.IInputValueFormatter _sortEnumTypeFormatter = default!;

        public global::System.String TypeName => "TraitSortInput";

        public void Initialize(global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _sortEnumTypeFormatter = serializerResolver.GetInputValueFormatter("SortEnumType");
        }

        public global::System.Object? Format(global::System.Object? runtimeValue)
        {
            if (runtimeValue is null)
            {
                return null;
            }

            if (!(runtimeValue is TraitSortInput d))
            {
                throw new global::System.ArgumentException(nameof(runtimeValue));
            }

            return new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>[] {
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "name",
                    FormatName(d.Name)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "description",
                    FormatDescription(d.Description)),
                new global::System.Collections.Generic.KeyValuePair<global::System.String, global::System.Object?>(
                    "id",
                    FormatId(d.Id))
            };
        }

        private global::System.Object? FormatName(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatDescription(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }

        private global::System.Object? FormatId(global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? value)
        {
            return _sortEnumTypeFormatter.Format(value);
        }
    }
}


// TraitSortInput.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class TraitSortInput
    {
        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Name { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Description { get; set; } = default!;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType? Id { get; set; } = default!;
    }
}


// SortEnumType.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public enum SortEnumType
    {
        Asc,
        Desc
    }
}


// SortEnumTypeSerializer.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SortEnumTypeSerializer
        : global::StrawberryShake.Serialization.IInputValueFormatter
        , global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, SortEnumType>
    {
        public global::System.String TypeName => "SortEnumType";

        public SortEnumType Parse(global::System.String serializedValue)
        {
            return serializedValue switch
            {
                "ASC" => SortEnumType.Asc,
                "DESC" => SortEnumType.Desc,
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }

        public global::System.Object Format(global::System.Object? runtimeValue)
        {
            return runtimeValue switch
            {
                SortEnumType.Asc => "ASC",
                SortEnumType.Desc => "DESC",
                _ => throw new global::StrawberryShake.GraphQLClientException()
            };
        }
    }
}


// GetFeatByIdQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetFeatById GraphQL operation
    /// <code>
    /// query GetFeatById($id: Uuid!) {
    ///   feats(where: { id: { eq: $id } }) {
    ///     __typename
    ///     items {
    ///       __typename
    ///       ... FeatById
    ///       ... on Feat {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatById on Feat {
    ///   id
    ///   name
    ///   level
    ///   special
    ///   trigger
    ///   frequency {
    ///     __typename
    ///     name
    ///     ... on Frequency {
    ///       id
    ///     }
    ///   }
    ///   rollableEffect {
    ///     __typename
    ///     criticalSuccess
    ///     success
    ///     failure
    ///     criticalFailure
    ///     ... on RollableEffect {
    ///       id
    ///     }
    ///   }
    ///   traits {
    ///     __typename
    ///     ... FeatById_Trait
    ///     ... on Trait {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatById_Trait on Trait {
    ///   id
    ///   name
    ///   description
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetFeatByIdQueryDocument()
        {
        }

        public static GetFeatByIdQueryDocument Instance { get; } = new GetFeatByIdQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x46, 0x65, 0x61, 0x74, 0x42, 0x79, 0x49, 0x64, 0x28, 0x24, 0x69, 0x64, 0x3a, 0x20, 0x55, 0x75, 0x69, 0x64, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x66, 0x65, 0x61, 0x74, 0x73, 0x28, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x3a, 0x20, 0x7b, 0x20, 0x65, 0x71, 0x3a, 0x20, 0x24, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x42, 0x79, 0x49, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x46, 0x65, 0x61, 0x74, 0x42, 0x79, 0x49, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6c, 0x65, 0x76, 0x65, 0x6c, 0x20, 0x73, 0x70, 0x65, 0x63, 0x69, 0x61, 0x6c, 0x20, 0x74, 0x72, 0x69, 0x67, 0x67, 0x65, 0x72, 0x20, 0x66, 0x72, 0x65, 0x71, 0x75, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x72, 0x65, 0x71, 0x75, 0x65, 0x6e, 0x63, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x72, 0x6f, 0x6c, 0x6c, 0x61, 0x62, 0x6c, 0x65, 0x45, 0x66, 0x66, 0x65, 0x63, 0x74, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x63, 0x72, 0x69, 0x74, 0x69, 0x63, 0x61, 0x6c, 0x53, 0x75, 0x63, 0x63, 0x65, 0x73, 0x73, 0x20, 0x73, 0x75, 0x63, 0x63, 0x65, 0x73, 0x73, 0x20, 0x66, 0x61, 0x69, 0x6c, 0x75, 0x72, 0x65, 0x20, 0x63, 0x72, 0x69, 0x74, 0x69, 0x63, 0x61, 0x6c, 0x46, 0x61, 0x69, 0x6c, 0x75, 0x72, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x6f, 0x6c, 0x6c, 0x61, 0x62, 0x6c, 0x65, 0x45, 0x66, 0x66, 0x65, 0x63, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x74, 0x72, 0x61, 0x69, 0x74, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x46, 0x65, 0x61, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "7a3455507a5f37559b3a48b37ee6c44fe6969695");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetFeatByIdQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetFeatById GraphQL operation
    /// <code>
    /// query GetFeatById($id: Uuid!) {
    ///   feats(where: { id: { eq: $id } }) {
    ///     __typename
    ///     items {
    ///       __typename
    ///       ... FeatById
    ///       ... on Feat {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatById on Feat {
    ///   id
    ///   name
    ///   level
    ///   special
    ///   trigger
    ///   frequency {
    ///     __typename
    ///     name
    ///     ... on Frequency {
    ///       id
    ///     }
    ///   }
    ///   rollableEffect {
    ///     __typename
    ///     criticalSuccess
    ///     success
    ///     failure
    ///     criticalFailure
    ///     ... on RollableEffect {
    ///       id
    ///     }
    ///   }
    ///   traits {
    ///     __typename
    ///     ... FeatById_Trait
    ///     ... on Trait {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatById_Trait on Trait {
    ///   id
    ///   name
    ///   description
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetFeatByIdResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _uuidFormatter;

        public GetFeatByIdQuery(
            global::StrawberryShake.IOperationExecutor<IGetFeatByIdResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _uuidFormatter = serializerResolver.GetInputValueFormatter("Uuid");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetFeatByIdResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetFeatByIdResult>> ExecuteAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(id);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetFeatByIdResult>> Watch(
            global::System.Guid id,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(id);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Guid id)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "id",
                FormatId(id));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetFeatByIdQueryDocument.Instance.Hash.Value,
                name: "GetFeatById",
                document: GetFeatByIdQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatId(global::System.Guid value)
        {
            return _uuidFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetFeatsPageQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetFeatsPage GraphQL operation
    /// <code>
    /// query GetFeatsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [FeatSortInput!] = [ { name: ASC } ]) {
    ///   feats(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { traits: { some: { name: { contains: $searchTerm } } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... FeatsPage
    ///       ... on Feat {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatsPage on Feat {
    ///   id
    ///   name
    ///   level
    ///   canBeLearnedMoreThanOnce
    ///   details {
    ///     __typename
    ///     text
    ///     ... on FeatDetailsBlock {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetFeatsPageQueryDocument()
        {
        }

        public static GetFeatsPageQueryDocument Instance { get; } = new GetFeatsPageQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x46, 0x65, 0x61, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x28, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x3a, 0x20, 0x53, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x21, 0x20, 0x3d, 0x20, 0x22, 0x22, 0x2c, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x5b, 0x46, 0x65, 0x61, 0x74, 0x53, 0x6f, 0x72, 0x74, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x5d, 0x20, 0x3d, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x41, 0x53, 0x43, 0x20, 0x7d, 0x20, 0x5d, 0x29, 0x20, 0x7b, 0x20, 0x66, 0x65, 0x61, 0x74, 0x73, 0x28, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x2c, 0x20, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x2c, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x2c, 0x20, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x3a, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x74, 0x72, 0x61, 0x69, 0x74, 0x73, 0x3a, 0x20, 0x7b, 0x20, 0x73, 0x6f, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x5d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x46, 0x65, 0x61, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6c, 0x65, 0x76, 0x65, 0x6c, 0x20, 0x63, 0x61, 0x6e, 0x42, 0x65, 0x4c, 0x65, 0x61, 0x72, 0x6e, 0x65, 0x64, 0x4d, 0x6f, 0x72, 0x65, 0x54, 0x68, 0x61, 0x6e, 0x4f, 0x6e, 0x63, 0x65, 0x20, 0x64, 0x65, 0x74, 0x61, 0x69, 0x6c, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x65, 0x78, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x44, 0x65, 0x74, 0x61, 0x69, 0x6c, 0x73, 0x42, 0x6c, 0x6f, 0x63, 0x6b, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "defcd7f67f31345e43429d1db7aa93bc8ca8af7d");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetFeatsPageQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetFeatsPage GraphQL operation
    /// <code>
    /// query GetFeatsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [FeatSortInput!] = [ { name: ASC } ]) {
    ///   feats(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { traits: { some: { name: { contains: $searchTerm } } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... FeatsPage
    ///       ... on Feat {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment FeatsPage on Feat {
    ///   id
    ///   name
    ///   level
    ///   canBeLearnedMoreThanOnce
    ///   details {
    ///     __typename
    ///     text
    ///     ... on FeatDetailsBlock {
    ///       id
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetFeatsPageResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _featSortInputFormatter;

        public GetFeatsPageQuery(
            global::StrawberryShake.IOperationExecutor<IGetFeatsPageResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _featSortInputFormatter = serializerResolver.GetInputValueFormatter("FeatSortInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetFeatsPageResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetFeatsPageResult>> ExecuteAsync(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatSortInput>? order,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetFeatsPageResult>> Watch(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatSortInput>? order,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatSortInput>? order)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "skip",
                FormatSkip(skip));
            variables.Add(
                "take",
                FormatTake(take));
            variables.Add(
                "searchTerm",
                FormatSearchTerm(searchTerm));
            variables.Add(
                "order",
                FormatOrder(order));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetFeatsPageQueryDocument.Instance.Hash.Value,
                name: "GetFeatsPage",
                document: GetFeatsPageQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatSkip(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatTake(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatSearchTerm(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatOrder(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatSortInput>? value)
        {
            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm is null)
                {
                    throw new global::System.ArgumentNullException(nameof(value_elm));
                }

                value_list.Add(_featSortInputFormatter.Format(value_elm));
            }
            return value_list;
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetRacesPageQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetRacesPage GraphQL operation
    /// <code>
    /// query GetRacesPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [RaceSortInput!] = [ { name: ASC } ]) {
    ///   races(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { rarity: { name: { contains: $searchTerm } } }, { language: { some: { name: { contains: $searchTerm } } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... RacesPage
    ///       ... on Race {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment RacesPage on Race {
    ///   id
    ///   name
    ///   baseSpeed
    ///   baseHealth
    ///   size {
    ///     __typename
    ///     ... RacesPage_Size
    ///     ... on RaceSize {
    ///       id
    ///     }
    ///   }
    ///   rarity {
    ///     __typename
    ///     ... RacesPage_Rarity
    ///     ... on RaceRarity {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment RacesPage_Size on RaceSize {
    ///   name
    /// }
    /// 
    /// fragment RacesPage_Rarity on RaceRarity {
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetRacesPageQueryDocument()
        {
        }

        public static GetRacesPageQueryDocument Instance { get; } = new GetRacesPageQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x28, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x3a, 0x20, 0x53, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x21, 0x20, 0x3d, 0x20, 0x22, 0x22, 0x2c, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x5b, 0x52, 0x61, 0x63, 0x65, 0x53, 0x6f, 0x72, 0x74, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x5d, 0x20, 0x3d, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x41, 0x53, 0x43, 0x20, 0x7d, 0x20, 0x5d, 0x29, 0x20, 0x7b, 0x20, 0x72, 0x61, 0x63, 0x65, 0x73, 0x28, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x2c, 0x20, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x2c, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x2c, 0x20, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x3a, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x72, 0x61, 0x72, 0x69, 0x74, 0x79, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x6c, 0x61, 0x6e, 0x67, 0x75, 0x61, 0x67, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x73, 0x6f, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x5d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x62, 0x61, 0x73, 0x65, 0x53, 0x70, 0x65, 0x65, 0x64, 0x20, 0x62, 0x61, 0x73, 0x65, 0x48, 0x65, 0x61, 0x6c, 0x74, 0x68, 0x20, 0x73, 0x69, 0x7a, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x5f, 0x53, 0x69, 0x7a, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x53, 0x69, 0x7a, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x72, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x5f, 0x52, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x52, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x5f, 0x53, 0x69, 0x7a, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x53, 0x69, 0x7a, 0x65, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x52, 0x61, 0x63, 0x65, 0x73, 0x50, 0x61, 0x67, 0x65, 0x5f, 0x52, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x6f, 0x6e, 0x20, 0x52, 0x61, 0x63, 0x65, 0x52, 0x61, 0x72, 0x69, 0x74, 0x79, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "48318411cffb58dd38222678ced51412cc5e937e");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetRacesPageQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetRacesPage GraphQL operation
    /// <code>
    /// query GetRacesPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [RaceSortInput!] = [ { name: ASC } ]) {
    ///   races(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { rarity: { name: { contains: $searchTerm } } }, { language: { some: { name: { contains: $searchTerm } } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... RacesPage
    ///       ... on Race {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment RacesPage on Race {
    ///   id
    ///   name
    ///   baseSpeed
    ///   baseHealth
    ///   size {
    ///     __typename
    ///     ... RacesPage_Size
    ///     ... on RaceSize {
    ///       id
    ///     }
    ///   }
    ///   rarity {
    ///     __typename
    ///     ... RacesPage_Rarity
    ///     ... on RaceRarity {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment RacesPage_Size on RaceSize {
    ///   name
    /// }
    /// 
    /// fragment RacesPage_Rarity on RaceRarity {
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetRacesPageResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _raceSortInputFormatter;

        public GetRacesPageQuery(
            global::StrawberryShake.IOperationExecutor<IGetRacesPageResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _raceSortInputFormatter = serializerResolver.GetInputValueFormatter("RaceSortInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetRacesPageResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetRacesPageResult>> ExecuteAsync(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSortInput>? order,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetRacesPageResult>> Watch(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSortInput>? order,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSortInput>? order)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "skip",
                FormatSkip(skip));
            variables.Add(
                "take",
                FormatTake(take));
            variables.Add(
                "searchTerm",
                FormatSearchTerm(searchTerm));
            variables.Add(
                "order",
                FormatOrder(order));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetRacesPageQueryDocument.Instance.Hash.Value,
                name: "GetRacesPage",
                document: GetRacesPageQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatSkip(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatTake(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatSearchTerm(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatOrder(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSortInput>? value)
        {
            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm is null)
                {
                    throw new global::System.ArgumentNullException(nameof(value_elm));
                }

                value_list.Add(_raceSortInputFormatter.Format(value_elm));
            }
            return value_list;
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetSpellsPageQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetSpellsPage GraphQL operation
    /// <code>
    /// query GetSpellsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [SpellSortInput!] = [ { name: ASC } ]) {
    ///   spells(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { actionType: { name: { contains: $searchTerm } } }, { featType: { name: { contains: $searchTerm } } }, { frequency: { name: { contains: $searchTerm } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       id
    ///       name
    ///       level
    ///       ... on Spell {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetSpellsPageQueryDocument()
        {
        }

        public static GetSpellsPageQueryDocument Instance { get; } = new GetSpellsPageQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x73, 0x50, 0x61, 0x67, 0x65, 0x28, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x3a, 0x20, 0x53, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x21, 0x20, 0x3d, 0x20, 0x22, 0x22, 0x2c, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x5b, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x53, 0x6f, 0x72, 0x74, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x5d, 0x20, 0x3d, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x41, 0x53, 0x43, 0x20, 0x7d, 0x20, 0x5d, 0x29, 0x20, 0x7b, 0x20, 0x73, 0x70, 0x65, 0x6c, 0x6c, 0x73, 0x28, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x2c, 0x20, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x2c, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x2c, 0x20, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x3a, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x61, 0x63, 0x74, 0x69, 0x6f, 0x6e, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x66, 0x65, 0x61, 0x74, 0x54, 0x79, 0x70, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x66, 0x72, 0x65, 0x71, 0x75, 0x65, 0x6e, 0x63, 0x79, 0x3a, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x5d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6c, 0x65, 0x76, 0x65, 0x6c, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "25f99fded4ebd223508893b5e8eee1df7a2e8a9e");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetSpellsPageQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetSpellsPage GraphQL operation
    /// <code>
    /// query GetSpellsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [SpellSortInput!] = [ { name: ASC } ]) {
    ///   spells(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { actionType: { name: { contains: $searchTerm } } }, { featType: { name: { contains: $searchTerm } } }, { frequency: { name: { contains: $searchTerm } } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       id
    ///       name
    ///       level
    ///       ... on Spell {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetSpellsPageResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _spellSortInputFormatter;

        public GetSpellsPageQuery(
            global::StrawberryShake.IOperationExecutor<IGetSpellsPageResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _spellSortInputFormatter = serializerResolver.GetInputValueFormatter("SpellSortInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetSpellsPageResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetSpellsPageResult>> ExecuteAsync(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellSortInput>? order,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetSpellsPageResult>> Watch(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellSortInput>? order,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellSortInput>? order)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "skip",
                FormatSkip(skip));
            variables.Add(
                "take",
                FormatTake(take));
            variables.Add(
                "searchTerm",
                FormatSearchTerm(searchTerm));
            variables.Add(
                "order",
                FormatOrder(order));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetSpellsPageQueryDocument.Instance.Hash.Value,
                name: "GetSpellsPage",
                document: GetSpellsPageQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatSkip(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatTake(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatSearchTerm(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatOrder(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellSortInput>? value)
        {
            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm is null)
                {
                    throw new global::System.ArgumentNullException(nameof(value_elm));
                }

                value_list.Add(_spellSortInputFormatter.Format(value_elm));
            }
            return value_list;
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetTraitByIdQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetTraitById GraphQL operation
    /// <code>
    /// query GetTraitById($id: Uuid!) {
    ///   traits(where: { id: { eq: $id } }) {
    ///     __typename
    ///     items {
    ///       __typename
    ///       ... TraitById
    ///       ... on Trait {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById on Trait {
    ///   id
    ///   name
    ///   description
    ///   feats {
    ///     __typename
    ///     ... TraitById_Feat
    ///     ... on Feat {
    ///       id
    ///     }
    ///   }
    ///   spells {
    ///     __typename
    ///     ... TraitById_Spell
    ///     ... on Spell {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById_Feat on Feat {
    ///   id
    ///   name
    ///   level
    ///   canBeLearnedMoreThanOnce
    /// }
    /// 
    /// fragment TraitById_Spell on Spell {
    ///   id
    ///   name
    ///   level
    ///   magicSchool {
    ///     __typename
    ///     ... TraitById_Spell_MagicSchool
    ///     ... on MagicSchool {
    ///       id
    ///     }
    ///   }
    ///   spellType {
    ///     __typename
    ///     ... TraitById_Spell_Type
    ///     ... on SpellType {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById_Spell_MagicSchool on MagicSchool {
    ///   id
    ///   name
    /// }
    /// 
    /// fragment TraitById_Spell_Type on SpellType {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetTraitByIdQueryDocument()
        {
        }

        public static GetTraitByIdQueryDocument Instance { get; } = new GetTraitByIdQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x28, 0x24, 0x69, 0x64, 0x3a, 0x20, 0x55, 0x75, 0x69, 0x64, 0x21, 0x29, 0x20, 0x7b, 0x20, 0x74, 0x72, 0x61, 0x69, 0x74, 0x73, 0x28, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x3a, 0x20, 0x7b, 0x20, 0x65, 0x71, 0x3a, 0x20, 0x24, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x66, 0x65, 0x61, 0x74, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x46, 0x65, 0x61, 0x74, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x73, 0x70, 0x65, 0x6c, 0x6c, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x46, 0x65, 0x61, 0x74, 0x20, 0x6f, 0x6e, 0x20, 0x46, 0x65, 0x61, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6c, 0x65, 0x76, 0x65, 0x6c, 0x20, 0x63, 0x61, 0x6e, 0x42, 0x65, 0x4c, 0x65, 0x61, 0x72, 0x6e, 0x65, 0x64, 0x4d, 0x6f, 0x72, 0x65, 0x54, 0x68, 0x61, 0x6e, 0x4f, 0x6e, 0x63, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x6c, 0x65, 0x76, 0x65, 0x6c, 0x20, 0x6d, 0x61, 0x67, 0x69, 0x63, 0x53, 0x63, 0x68, 0x6f, 0x6f, 0x6c, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x5f, 0x4d, 0x61, 0x67, 0x69, 0x63, 0x53, 0x63, 0x68, 0x6f, 0x6f, 0x6c, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x4d, 0x61, 0x67, 0x69, 0x63, 0x53, 0x63, 0x68, 0x6f, 0x6f, 0x6c, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x73, 0x70, 0x65, 0x6c, 0x6c, 0x54, 0x79, 0x70, 0x65, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x5f, 0x54, 0x79, 0x70, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x54, 0x79, 0x70, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x5f, 0x4d, 0x61, 0x67, 0x69, 0x63, 0x53, 0x63, 0x68, 0x6f, 0x6f, 0x6c, 0x20, 0x6f, 0x6e, 0x20, 0x4d, 0x61, 0x67, 0x69, 0x63, 0x53, 0x63, 0x68, 0x6f, 0x6f, 0x6c, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x42, 0x79, 0x49, 0x64, 0x5f, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x5f, 0x54, 0x79, 0x70, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x53, 0x70, 0x65, 0x6c, 0x6c, 0x54, 0x79, 0x70, 0x65, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "05489be8d8bc94a90c6dce7da814da1df7054d2f");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetTraitByIdQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetTraitById GraphQL operation
    /// <code>
    /// query GetTraitById($id: Uuid!) {
    ///   traits(where: { id: { eq: $id } }) {
    ///     __typename
    ///     items {
    ///       __typename
    ///       ... TraitById
    ///       ... on Trait {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById on Trait {
    ///   id
    ///   name
    ///   description
    ///   feats {
    ///     __typename
    ///     ... TraitById_Feat
    ///     ... on Feat {
    ///       id
    ///     }
    ///   }
    ///   spells {
    ///     __typename
    ///     ... TraitById_Spell
    ///     ... on Spell {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById_Feat on Feat {
    ///   id
    ///   name
    ///   level
    ///   canBeLearnedMoreThanOnce
    /// }
    /// 
    /// fragment TraitById_Spell on Spell {
    ///   id
    ///   name
    ///   level
    ///   magicSchool {
    ///     __typename
    ///     ... TraitById_Spell_MagicSchool
    ///     ... on MagicSchool {
    ///       id
    ///     }
    ///   }
    ///   spellType {
    ///     __typename
    ///     ... TraitById_Spell_Type
    ///     ... on SpellType {
    ///       id
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitById_Spell_MagicSchool on MagicSchool {
    ///   id
    ///   name
    /// }
    /// 
    /// fragment TraitById_Spell_Type on SpellType {
    ///   id
    ///   name
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetTraitByIdResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _uuidFormatter;

        public GetTraitByIdQuery(
            global::StrawberryShake.IOperationExecutor<IGetTraitByIdResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _uuidFormatter = serializerResolver.GetInputValueFormatter("Uuid");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetTraitByIdResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetTraitByIdResult>> ExecuteAsync(
            global::System.Guid id,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(id);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetTraitByIdResult>> Watch(
            global::System.Guid id,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(id);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Guid id)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "id",
                FormatId(id));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetTraitByIdQueryDocument.Instance.Hash.Value,
                name: "GetTraitById",
                document: GetTraitByIdQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatId(global::System.Guid value)
        {
            return _uuidFormatter.Format(value);
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetTraitsPageQueryDocument.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetTraitsPage GraphQL operation
    /// <code>
    /// query GetTraitsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [TraitSortInput!] = [ { name: ASC } ]) {
    ///   traits(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { description: { contains: $searchTerm } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... TraitsPage
    ///       ... on Trait {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitsPage on Trait {
    ///   id
    ///   name
    ///   description
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageQueryDocument
        : global::StrawberryShake.IDocument
    {
        private GetTraitsPageQueryDocument()
        {
        }

        public static GetTraitsPageQueryDocument Instance { get; } = new GetTraitsPageQueryDocument();

        public global::StrawberryShake.OperationKind Kind => global::StrawberryShake.OperationKind.Query;

        public global::System.ReadOnlySpan<global::System.Byte> Body => new global::System.Byte[]{ 0x71, 0x75, 0x65, 0x72, 0x79, 0x20, 0x47, 0x65, 0x74, 0x54, 0x72, 0x61, 0x69, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x28, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x49, 0x6e, 0x74, 0x21, 0x2c, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x3a, 0x20, 0x53, 0x74, 0x72, 0x69, 0x6e, 0x67, 0x21, 0x20, 0x3d, 0x20, 0x22, 0x22, 0x2c, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x5b, 0x54, 0x72, 0x61, 0x69, 0x74, 0x53, 0x6f, 0x72, 0x74, 0x49, 0x6e, 0x70, 0x75, 0x74, 0x21, 0x5d, 0x20, 0x3d, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x41, 0x53, 0x43, 0x20, 0x7d, 0x20, 0x5d, 0x29, 0x20, 0x7b, 0x20, 0x74, 0x72, 0x61, 0x69, 0x74, 0x73, 0x28, 0x73, 0x6b, 0x69, 0x70, 0x3a, 0x20, 0x24, 0x73, 0x6b, 0x69, 0x70, 0x2c, 0x20, 0x74, 0x61, 0x6b, 0x65, 0x3a, 0x20, 0x24, 0x74, 0x61, 0x6b, 0x65, 0x2c, 0x20, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x3a, 0x20, 0x24, 0x6f, 0x72, 0x64, 0x65, 0x72, 0x2c, 0x20, 0x77, 0x68, 0x65, 0x72, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x6f, 0x72, 0x3a, 0x20, 0x5b, 0x20, 0x7b, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x2c, 0x20, 0x7b, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x3a, 0x20, 0x7b, 0x20, 0x63, 0x6f, 0x6e, 0x74, 0x61, 0x69, 0x6e, 0x73, 0x3a, 0x20, 0x24, 0x73, 0x65, 0x61, 0x72, 0x63, 0x68, 0x54, 0x65, 0x72, 0x6d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x5d, 0x20, 0x7d, 0x29, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x74, 0x6f, 0x74, 0x61, 0x6c, 0x43, 0x6f, 0x75, 0x6e, 0x74, 0x20, 0x69, 0x74, 0x65, 0x6d, 0x73, 0x20, 0x7b, 0x20, 0x5f, 0x5f, 0x74, 0x79, 0x70, 0x65, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x2e, 0x2e, 0x2e, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x7d, 0x20, 0x66, 0x72, 0x61, 0x67, 0x6d, 0x65, 0x6e, 0x74, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x73, 0x50, 0x61, 0x67, 0x65, 0x20, 0x6f, 0x6e, 0x20, 0x54, 0x72, 0x61, 0x69, 0x74, 0x20, 0x7b, 0x20, 0x69, 0x64, 0x20, 0x6e, 0x61, 0x6d, 0x65, 0x20, 0x64, 0x65, 0x73, 0x63, 0x72, 0x69, 0x70, 0x74, 0x69, 0x6f, 0x6e, 0x20, 0x7d };

        public global::StrawberryShake.DocumentHash Hash { get; } = new global::StrawberryShake.DocumentHash("sha1Hash", "0ed74f515cc4fd7e282d3e1971ce0058eee667d0");

        public override global::System.String ToString()
        {
            #if NETSTANDARD2_0
            return global::System.Text.Encoding.UTF8.GetString(Body.ToArray());
            #else
            return global::System.Text.Encoding.UTF8.GetString(Body);
            #endif
        }
    }
}


// GetTraitsPageQuery.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the operation service of the GetTraitsPage GraphQL operation
    /// <code>
    /// query GetTraitsPage($skip: Int!, $take: Int!, $searchTerm: String! = "", $order: [TraitSortInput!] = [ { name: ASC } ]) {
    ///   traits(skip: $skip, take: $take, order: $order, where: { or: [ { name: { contains: $searchTerm } }, { description: { contains: $searchTerm } } ] }) {
    ///     __typename
    ///     totalCount
    ///     items {
    ///       __typename
    ///       ... TraitsPage
    ///       ... on Trait {
    ///         id
    ///       }
    ///     }
    ///   }
    /// }
    /// 
    /// fragment TraitsPage on Trait {
    ///   id
    ///   name
    ///   description
    /// }
    /// </code>
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageQuery
        : global::StrawberryShake.IOperationRequestFactory
    {
        private readonly global::StrawberryShake.IOperationExecutor<IGetTraitsPageResult> _operationExecutor;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _intFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _stringFormatter;
        private readonly global::StrawberryShake.Serialization.IInputValueFormatter _traitSortInputFormatter;

        public GetTraitsPageQuery(
            global::StrawberryShake.IOperationExecutor<IGetTraitsPageResult> operationExecutor,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _operationExecutor = operationExecutor
                 ?? throw new global::System.ArgumentNullException(nameof(operationExecutor));
            _intFormatter = serializerResolver.GetInputValueFormatter("Int");
            _stringFormatter = serializerResolver.GetInputValueFormatter("String");
            _traitSortInputFormatter = serializerResolver.GetInputValueFormatter("TraitSortInput");
        }

        global::System.Type global::StrawberryShake.IOperationRequestFactory.ResultType => typeof(IGetTraitsPageResult);

        public async global::System.Threading.Tasks.Task<global::StrawberryShake.IOperationResult<IGetTraitsPageResult>> ExecuteAsync(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.TraitSortInput>? order,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);

            return await _operationExecutor
                .ExecuteAsync(
                    request,
                    cancellationToken)
                .ConfigureAwait(false);
        }

        public global::System.IObservable<global::StrawberryShake.IOperationResult<IGetTraitsPageResult>> Watch(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.TraitSortInput>? order,
            global::StrawberryShake.ExecutionStrategy? strategy = null)
        {
            var request = CreateRequest(
                skip,
                take,
                searchTerm,
                order);
            return _operationExecutor.Watch(
                request,
                strategy);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(
            global::System.Int32 skip,
            global::System.Int32 take,
            global::System.String searchTerm,
            global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.TraitSortInput>? order)
        {
            var variables = new global::System.Collections.Generic.Dictionary<global::System.String, global::System.Object?>();

            variables.Add(
                "skip",
                FormatSkip(skip));
            variables.Add(
                "take",
                FormatTake(take));
            variables.Add(
                "searchTerm",
                FormatSearchTerm(searchTerm));
            variables.Add(
                "order",
                FormatOrder(order));

            return CreateRequest(variables);
        }

        private global::StrawberryShake.OperationRequest CreateRequest(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {

            return new global::StrawberryShake.OperationRequest(
                id: GetTraitsPageQueryDocument.Instance.Hash.Value,
                name: "GetTraitsPage",
                document: GetTraitsPageQueryDocument.Instance,
                strategy: global::StrawberryShake.RequestStrategy.Default,
                variables:variables);
        }

        private global::System.Object? FormatSkip(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatTake(global::System.Int32 value)
        {
            return _intFormatter.Format(value);
        }

        private global::System.Object? FormatSearchTerm(global::System.String value)
        {
            if (value is null)
            {
                throw new global::System.ArgumentNullException(nameof(value));
            }

            return _stringFormatter.Format(value);
        }

        private global::System.Object? FormatOrder(global::System.Collections.Generic.IReadOnlyList<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.TraitSortInput>? value)
        {
            var value_list = new global::System.Collections.Generic.List<global::System.Object?>();

            foreach (var value_elm in value)
            {
                if (value_elm is null)
                {
                    throw new global::System.ArgumentNullException(nameof(value_elm));
                }

                value_list.Add(_traitSortInputFormatter.Format(value_elm));
            }
            return value_list;
        }

        global::StrawberryShake.OperationRequest global::StrawberryShake.IOperationRequestFactory.Create(global::System.Collections.Generic.IReadOnlyDictionary<global::System.String, global::System.Object?>? variables)
        {
            return CreateRequest(variables!);
        }
    }
}


// GetFeatByIdBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatByIdBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;

        public GetFeatByIdBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetFeatByIdResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetFeatByIdResult Result, GetFeatByIdResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetFeatByIdResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetFeatByIdResult, GetFeatByIdResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? featsId = default!;
            _entityStore.Update(session => 
            {
                featsId = DeserializeIGetFeatById_Feats(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "feats"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetFeatByIdResultInfo(
                featsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? DeserializeIGetFeatById_Feats(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("FeatCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData(
                    typename,
                    items: UpdateIGetFeatById_Feats_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetFeatById_Feats_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var feats = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                feats.Add(UpdateIGetFeatById_Feats_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return feats;
        }

        private global::StrawberryShake.EntityId? UpdateIGetFeatById_Feats_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "special")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "trigger")),
                            UpdateIGetFeatById_Feats_Items_FrequencyEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "frequency"),
                                entityIds),
                            UpdateIGetFeatById_Feats_Items_RollableEffectEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rollableEffect"),
                                entityIds),
                            UpdateNonNullableIGetFeatById_Feats_Items_TraitsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "traits"),
                                entityIds),
                            entity.CanBeLearnedMoreThanOnce,
                            entity.Details));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "special")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "trigger")),
                            UpdateIGetFeatById_Feats_Items_FrequencyEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "frequency"),
                                entityIds),
                            UpdateIGetFeatById_Feats_Items_RollableEffectEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rollableEffect"),
                                entityIds),
                            UpdateNonNullableIGetFeatById_Feats_Items_TraitsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "traits"),
                                entityIds),
                            default!,
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.String? DeserializeString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::StrawberryShake.EntityId? UpdateIGetFeatById_Feats_Items_FrequencyEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Frequency",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId? UpdateIGetFeatById_Feats_Items_RollableEffectEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "RollableEffect",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity(
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "criticalSuccess")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "success")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "failure")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "criticalFailure"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity(
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "criticalSuccess")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "success")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "failure")),
                            DeserializeString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "criticalFailure"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetFeatById_Feats_Items_TraitsEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var traits = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                traits.Add(UpdateNonNullableIGetFeatById_Feats_Items_TraitsEntity(
                    session,
                    child,
                    entityIds));
            }

            return traits;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetFeatById_Feats_Items_TraitsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            entity.Feats,
                            entity.Spells));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            default!,
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetFeatsPageBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetFeatsPageBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType> _sortEnumTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Boolean, global::System.Boolean> _booleanParser;

        public GetFeatsPageBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _sortEnumTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType>("SortEnumType")
                 ?? throw new global::System.ArgumentException("No serializer for type `SortEnumType` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
            _booleanParser = serializerResolver.GetLeafValueParser<global::System.Boolean, global::System.Boolean>("Boolean")
                 ?? throw new global::System.ArgumentException("No serializer for type `Boolean` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetFeatsPageResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetFeatsPageResult Result, GetFeatsPageResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetFeatsPageResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetFeatsPageResult, GetFeatsPageResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? featsId = default!;
            _entityStore.Update(session => 
            {
                featsId = DeserializeIGetFeatsPage_Feats(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "feats"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetFeatsPageResultInfo(
                featsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData? DeserializeIGetFeatsPage_Feats(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("FeatCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatCollectionSegmentData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    items: UpdateIGetFeatsPage_Feats_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetFeatsPage_Feats_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var feats = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                feats.Add(UpdateIGetFeatsPage_Feats_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return feats;
        }

        private global::StrawberryShake.EntityId? UpdateIGetFeatsPage_Feats_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            entity.Special,
                            entity.Trigger,
                            entity.Frequency,
                            entity.RollableEffect,
                            entity.Traits,
                            DeserializeNonNullableBoolean(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "canBeLearnedMoreThanOnce")),
                            UpdateNonNullableIGetFeatsPage_Feats_Items_DetailsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "details"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            default!,
                            default!,
                            default!,
                            default!,
                            default!,
                            DeserializeNonNullableBoolean(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "canBeLearnedMoreThanOnce")),
                            UpdateNonNullableIGetFeatsPage_Feats_Items_DetailsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "details"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Boolean DeserializeNonNullableBoolean(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _booleanParser.Parse(obj.Value.GetBoolean()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetFeatsPage_Feats_Items_DetailsEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var featDetailsBlocks = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                featDetailsBlocks.Add(UpdateNonNullableIGetFeatsPage_Feats_Items_DetailsEntity(
                    session,
                    child,
                    entityIds));
            }

            return featDetailsBlocks;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetFeatsPage_Feats_Items_DetailsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "FeatDetailsBlock",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "text"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "text"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetRacesPageBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetRacesPageBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType> _sortEnumTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;

        public GetRacesPageBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _sortEnumTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType>("SortEnumType")
                 ?? throw new global::System.ArgumentException("No serializer for type `SortEnumType` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetRacesPageResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetRacesPageResult Result, GetRacesPageResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetRacesPageResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetRacesPageResult, GetRacesPageResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData? racesId = default!;
            _entityStore.Update(session => 
            {
                racesId = DeserializeIGetRacesPage_Races(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "races"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetRacesPageResultInfo(
                racesId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData? DeserializeIGetRacesPage_Races(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("RaceCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceCollectionSegmentData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    items: UpdateIGetRacesPage_Races_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetRacesPage_Races_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var races = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                races.Add(UpdateIGetRacesPage_Races_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return races;
        }

        private global::StrawberryShake.EntityId? UpdateIGetRacesPage_Races_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Race",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "baseSpeed")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "baseHealth")),
                            UpdateNonNullableIGetRacesPage_Races_Items_SizeEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "size"),
                                entityIds),
                            UpdateNonNullableIGetRacesPage_Races_Items_RarityEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rarity"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "baseSpeed")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "baseHealth")),
                            UpdateNonNullableIGetRacesPage_Races_Items_SizeEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "size"),
                                entityIds),
                            UpdateNonNullableIGetRacesPage_Races_Items_RarityEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "rarity"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetRacesPage_Races_Items_SizeEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "RaceSize",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetRacesPage_Races_Items_RarityEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "RaceRarity",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity(DeserializeNonNullableString(
                            global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                obj,
                                "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetSpellsPageBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetSpellsPageBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType> _sortEnumTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;

        public GetSpellsPageBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _sortEnumTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType>("SortEnumType")
                 ?? throw new global::System.ArgumentException("No serializer for type `SortEnumType` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetSpellsPageResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetSpellsPageResult Result, GetSpellsPageResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetSpellsPageResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetSpellsPageResult, GetSpellsPageResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData? spellsId = default!;
            _entityStore.Update(session => 
            {
                spellsId = DeserializeIGetSpellsPage_Spells(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "spells"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetSpellsPageResultInfo(
                spellsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData? DeserializeIGetSpellsPage_Spells(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("SpellCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellCollectionSegmentData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    items: UpdateIGetSpellsPage_Spells_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetSpellsPage_Spells_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var spells = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                spells.Add(UpdateIGetSpellsPage_Spells_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return spells;
        }

        private global::StrawberryShake.EntityId? UpdateIGetSpellsPage_Spells_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Spell",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            entity.MagicSchool,
                            entity.SpellType));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            default!,
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}


// GetTraitByIdBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitByIdBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Boolean, global::System.Boolean> _booleanParser;

        public GetTraitByIdBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _booleanParser = serializerResolver.GetLeafValueParser<global::System.Boolean, global::System.Boolean>("Boolean")
                 ?? throw new global::System.ArgumentException("No serializer for type `Boolean` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetTraitByIdResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetTraitByIdResult Result, GetTraitByIdResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetTraitByIdResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetTraitByIdResult, GetTraitByIdResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? traitsId = default!;
            _entityStore.Update(session => 
            {
                traitsId = DeserializeIGetTraitById_Traits(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "traits"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetTraitByIdResultInfo(
                traitsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? DeserializeIGetTraitById_Traits(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("TraitCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData(
                    typename,
                    items: UpdateIGetTraitById_Traits_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetTraitById_Traits_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var traits = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                traits.Add(UpdateIGetTraitById_Traits_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return traits;
        }

        private global::StrawberryShake.EntityId? UpdateIGetTraitById_Traits_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            UpdateNonNullableIGetTraitById_Traits_Items_FeatsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "feats"),
                                entityIds),
                            UpdateNonNullableIGetTraitById_Traits_Items_SpellsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "spells"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            UpdateNonNullableIGetTraitById_Traits_Items_FeatsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "feats"),
                                entityIds),
                            UpdateNonNullableIGetTraitById_Traits_Items_SpellsEntityNonNullableArray(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "spells"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetTraitById_Traits_Items_FeatsEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var feats = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                feats.Add(UpdateNonNullableIGetTraitById_Traits_Items_FeatsEntity(
                    session,
                    child,
                    entityIds));
            }

            return feats;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetTraitById_Traits_Items_FeatsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Feat",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            entity.Special,
                            entity.Trigger,
                            entity.Frequency,
                            entity.RollableEffect,
                            entity.Traits,
                            DeserializeNonNullableBoolean(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "canBeLearnedMoreThanOnce")),
                            entity.Details));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            default!,
                            default!,
                            default!,
                            default!,
                            default!,
                            DeserializeNonNullableBoolean(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "canBeLearnedMoreThanOnce")),
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Boolean DeserializeNonNullableBoolean(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _booleanParser.Parse(obj.Value.GetBoolean()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId> UpdateNonNullableIGetTraitById_Traits_Items_SpellsEntityNonNullableArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            var spells = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                spells.Add(UpdateNonNullableIGetTraitById_Traits_Items_SpellsEntity(
                    session,
                    child,
                    entityIds));
            }

            return spells;
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetTraitById_Traits_Items_SpellsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Spell",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            UpdateNonNullableIGetTraitById_Traits_Items_Spells_MagicSchoolEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "magicSchool"),
                                entityIds),
                            UpdateNonNullableIGetTraitById_Traits_Items_Spells_SpellTypeEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "spellType"),
                                entityIds)));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableInt32(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "level")),
                            UpdateNonNullableIGetTraitById_Traits_Items_Spells_MagicSchoolEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "magicSchool"),
                                entityIds),
                            UpdateNonNullableIGetTraitById_Traits_Items_Spells_SpellTypeEntity(
                                session,
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "spellType"),
                                entityIds)));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetTraitById_Traits_Items_Spells_MagicSchoolEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "MagicSchool",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::StrawberryShake.EntityId UpdateNonNullableIGetTraitById_Traits_Items_Spells_SpellTypeEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "SpellType",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name"))));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }
    }
}


// GetTraitsPageBuilder.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class GetTraitsPageBuilder
        : global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>
    {
        private readonly global::StrawberryShake.IEntityStore _entityStore;
        private readonly global::StrawberryShake.IEntityIdSerializer _idSerializer;
        private readonly global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult> _resultDataFactory;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType> _sortEnumTypeParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Int32, global::System.Int32> _intParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.String, global::System.String> _stringParser;
        private readonly global::StrawberryShake.Serialization.ILeafValueParser<global::System.Guid, global::System.Guid> _uuidParser;

        public GetTraitsPageBuilder(
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer idSerializer,
            global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult> resultDataFactory,
            global::StrawberryShake.Serialization.ISerializerResolver serializerResolver)
        {
            _entityStore = entityStore
                 ?? throw new global::System.ArgumentNullException(nameof(entityStore));
            _idSerializer = idSerializer
                 ?? throw new global::System.ArgumentNullException(nameof(idSerializer));
            _resultDataFactory = resultDataFactory
                 ?? throw new global::System.ArgumentNullException(nameof(resultDataFactory));
            _sortEnumTypeParser = serializerResolver.GetLeafValueParser<global::System.String, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumType>("SortEnumType")
                 ?? throw new global::System.ArgumentException("No serializer for type `SortEnumType` found.");
            _intParser = serializerResolver.GetLeafValueParser<global::System.Int32, global::System.Int32>("Int")
                 ?? throw new global::System.ArgumentException("No serializer for type `Int` found.");
            _stringParser = serializerResolver.GetLeafValueParser<global::System.String, global::System.String>("String")
                 ?? throw new global::System.ArgumentException("No serializer for type `String` found.");
            _uuidParser = serializerResolver.GetLeafValueParser<global::System.Guid, global::System.Guid>("Uuid")
                 ?? throw new global::System.ArgumentException("No serializer for type `Uuid` found.");
        }

        public global::StrawberryShake.IOperationResult<IGetTraitsPageResult> Build(global::StrawberryShake.Response<global::System.Text.Json.JsonDocument> response)
        {
            (IGetTraitsPageResult Result, GetTraitsPageResultInfo Info)? data = null;
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.IClientError>? errors = null;

            if (response.Body != null)
            {
                if (response.Body.RootElement.TryGetProperty("data", out global::System.Text.Json.JsonElement dataElement))
                {
                    data = BuildData(dataElement);
                }
                if (response.Body.RootElement.TryGetProperty("errors", out global::System.Text.Json.JsonElement errorsElement))
                {
                    errors = global::StrawberryShake.Json.JsonErrorParser.ParseErrors(errorsElement);
                }
            }

            return new global::StrawberryShake.OperationResult<IGetTraitsPageResult>(
                data?.Result,
                data?.Info,
                _resultDataFactory,
                errors);
        }

        private (IGetTraitsPageResult, GetTraitsPageResultInfo) BuildData(global::System.Text.Json.JsonElement obj)
        {
            var entityIds = new global::System.Collections.Generic.HashSet<global::StrawberryShake.EntityId>();
            global::StrawberryShake.IEntityStoreSnapshot snapshot = default!;

            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? traitsId = default!;
            _entityStore.Update(session => 
            {
                traitsId = DeserializeIGetTraitsPage_Traits(
                    session,
                    global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                        obj,
                        "traits"),
                    entityIds);

                snapshot = session.CurrentSnapshot;
            });

            var resultInfo = new GetTraitsPageResultInfo(
                traitsId,
                entityIds,
                snapshot.Version);

            return (
                _resultDataFactory.Create(resultInfo),
                resultInfo
            );
        }

        private global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData? DeserializeIGetTraitsPage_Traits(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var typename = obj.Value
                .GetProperty("__typename")
                .GetString();

            if (typename?.Equals("TraitCollectionSegment", global::System.StringComparison.Ordinal) ?? false)
            {
                return new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitCollectionSegmentData(
                    typename,
                    totalCount: DeserializeNonNullableInt32(
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "totalCount")),
                    items: UpdateIGetTraitsPage_Traits_ItemsEntityArray(
                        session,
                        global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                            obj,
                            "items"),
                        entityIds));
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Int32 DeserializeNonNullableInt32(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _intParser.Parse(obj.Value.GetInt32()!);
        }

        private global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? UpdateIGetTraitsPage_Traits_ItemsEntityArray(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            var traits = new global::System.Collections.Generic.List<global::StrawberryShake.EntityId?>();

            foreach (global::System.Text.Json.JsonElement child in obj.Value.EnumerateArray())
            {
                traits.Add(UpdateIGetTraitsPage_Traits_ItemsEntity(
                    session,
                    child,
                    entityIds));
            }

            return traits;
        }

        private global::StrawberryShake.EntityId? UpdateIGetTraitsPage_Traits_ItemsEntity(
            global::StrawberryShake.IEntityStoreUpdateSession session,
            global::System.Text.Json.JsonElement? obj,
            global::System.Collections.Generic.ISet<global::StrawberryShake.EntityId> entityIds)
        {
            if (!obj.HasValue)
            {
                return null;
            }

            global::StrawberryShake.EntityId entityId = _idSerializer.Parse(obj.Value);
            entityIds.Add(entityId);


            if (entityId.Name.Equals(
                    "Trait",
                    global::System.StringComparison.Ordinal))
            {
                if (session.CurrentSnapshot.TryGetEntity(
                        entityId,
                        out global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity? entity))
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            entity.Feats,
                            entity.Spells));
                }
                else
                {
                    session.SetEntity(
                        entityId,
                        new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity(
                            DeserializeNonNullableGuid(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "id")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "name")),
                            DeserializeNonNullableString(
                                global::StrawberryShake.Json.JsonElementExtensions.GetPropertyOrNull(
                                    obj,
                                    "description")),
                            default!,
                            default!));
                }

                return entityId;
            }

            throw new global::System.NotSupportedException();
        }

        private global::System.Guid DeserializeNonNullableGuid(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _uuidParser.Parse(obj.Value.GetGuid()!);
        }

        private global::System.String DeserializeNonNullableString(global::System.Text.Json.JsonElement? obj)
        {
            if (!obj.HasValue)
            {
                throw new global::System.ArgumentNullException();
            }

            return _stringParser.Parse(obj.Value.GetString()!);
        }
    }
}


// FeatCollectionSegmentData.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class FeatCollectionSegmentData
    {
        public FeatCollectionSegmentData(
            global::System.String typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? items = null,
            global::System.Int32? totalCount = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            Items = items;
            TotalCount = totalCount;
        }

        public global::System.String __typename { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Items { get; }

        public global::System.Int32? TotalCount { get; }
    }
}


// RaceCollectionSegmentData.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class RaceCollectionSegmentData
    {
        public RaceCollectionSegmentData(
            global::System.String typename,
            global::System.Int32? totalCount = null,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? items = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.String __typename { get; }

        public global::System.Int32? TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Items { get; }
    }
}


// SpellCollectionSegmentData.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class SpellCollectionSegmentData
    {
        public SpellCollectionSegmentData(
            global::System.String typename,
            global::System.Int32? totalCount = null,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? items = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            TotalCount = totalCount;
            Items = items;
        }

        public global::System.String __typename { get; }

        public global::System.Int32? TotalCount { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Items { get; }
    }
}


// TraitCollectionSegmentData.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class TraitCollectionSegmentData
    {
        public TraitCollectionSegmentData(
            global::System.String typename,
            global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? items = null,
            global::System.Int32? totalCount = null)
        {
            __typename = typename
                 ?? throw new global::System.ArgumentNullException(nameof(typename));
            Items = items;
            TotalCount = totalCount;
        }

        public global::System.String __typename { get; }

        public global::System.Collections.Generic.IReadOnlyList<global::StrawberryShake.EntityId?>? Items { get; }

        public global::System.Int32? TotalCount { get; }
    }
}


// PathfinderOfficialApi.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated
{
    /// <summary>
    /// Represents the PathfinderOfficialApi GraphQL client
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class PathfinderOfficialApi
    {
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery _getFeatById;
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery _getFeatsPage;
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery _getRacesPage;
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery _getSpellsPage;
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery _getTraitById;
        private readonly global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery _getTraitsPage;

        public PathfinderOfficialApi(
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery getFeatById,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery getFeatsPage,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery getRacesPage,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery getSpellsPage,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery getTraitById,
            global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery getTraitsPage)
        {
            _getFeatById = getFeatById
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatById));
            _getFeatsPage = getFeatsPage
                 ?? throw new global::System.ArgumentNullException(nameof(getFeatsPage));
            _getRacesPage = getRacesPage
                 ?? throw new global::System.ArgumentNullException(nameof(getRacesPage));
            _getSpellsPage = getSpellsPage
                 ?? throw new global::System.ArgumentNullException(nameof(getSpellsPage));
            _getTraitById = getTraitById
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitById));
            _getTraitsPage = getTraitsPage
                 ?? throw new global::System.ArgumentNullException(nameof(getTraitsPage));
        }

        public static global::System.String ClientName => "PathfinderOfficialApi";

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery GetFeatById => _getFeatById;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery GetFeatsPage => _getFeatsPage;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery GetRacesPage => _getRacesPage;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery GetSpellsPage => _getSpellsPage;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery GetTraitById => _getTraitById;

        public global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery GetTraitsPage => _getTraitsPage;
    }
}


// PathfinderOfficialApiEntityIdFactory.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class PathfinderOfficialApiEntityIdFactory
        : global::StrawberryShake.IEntityIdSerializer
    {
        private static readonly global::System.Text.Json.JsonWriterOptions _options = new global::System.Text.Json.JsonWriterOptions(){ Indented = false };

        public global::StrawberryShake.EntityId Parse(global::System.Text.Json.JsonElement obj)
        {
            global::System.String typeName = obj
                .GetProperty("__typename")
                .GetString()!;

            return typeName switch
            {
                "Feat" => ParseFeatEntityId(
                    obj,
                    typeName),
                "Frequency" => ParseFrequencyEntityId(
                    obj,
                    typeName),
                "RollableEffect" => ParseRollableEffectEntityId(
                    obj,
                    typeName),
                "Trait" => ParseTraitEntityId(
                    obj,
                    typeName),
                "FeatDetailsBlock" => ParseFeatDetailsBlockEntityId(
                    obj,
                    typeName),
                "Race" => ParseRaceEntityId(
                    obj,
                    typeName),
                "RaceSize" => ParseRaceSizeEntityId(
                    obj,
                    typeName),
                "RaceRarity" => ParseRaceRarityEntityId(
                    obj,
                    typeName),
                "Spell" => ParseSpellEntityId(
                    obj,
                    typeName),
                "MagicSchool" => ParseMagicSchoolEntityId(
                    obj,
                    typeName),
                "SpellType" => ParseSpellTypeEntityId(
                    obj,
                    typeName),
                _ => throw new global::System.NotSupportedException()
            };
        }

        public global::System.String Format(global::StrawberryShake.EntityId entityId)
        {
            return entityId.Name switch
            {
                "Feat" => FormatFeatEntityId(entityId),
                "Frequency" => FormatFrequencyEntityId(entityId),
                "RollableEffect" => FormatRollableEffectEntityId(entityId),
                "Trait" => FormatTraitEntityId(entityId),
                "FeatDetailsBlock" => FormatFeatDetailsBlockEntityId(entityId),
                "Race" => FormatRaceEntityId(entityId),
                "RaceSize" => FormatRaceSizeEntityId(entityId),
                "RaceRarity" => FormatRaceRarityEntityId(entityId),
                "Spell" => FormatSpellEntityId(entityId),
                "MagicSchool" => FormatMagicSchoolEntityId(entityId),
                "SpellType" => FormatSpellTypeEntityId(entityId),
                _ => throw new global::System.NotSupportedException()
            };
        }

        private global::StrawberryShake.EntityId ParseFeatEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatFeatEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseFrequencyEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatFrequencyEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseRollableEffectEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatRollableEffectEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseTraitEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatTraitEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseFeatDetailsBlockEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatFeatDetailsBlockEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseRaceEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatRaceEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseRaceSizeEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatRaceSizeEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseRaceRarityEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatRaceRarityEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseSpellEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatSpellEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseMagicSchoolEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatMagicSchoolEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }

        private global::StrawberryShake.EntityId ParseSpellTypeEntityId(
            global::System.Text.Json.JsonElement obj,
            global::System.String type)
        {
            return new global::StrawberryShake.EntityId(
                type,
                obj
                    .GetProperty("id")
                    .GetGuid()!);
        }

        private global::System.String FormatSpellTypeEntityId(global::StrawberryShake.EntityId entityId)
        {
            using var writer = new global::StrawberryShake.Internal.ArrayWriter();
            using var jsonWriter = new global::System.Text.Json.Utf8JsonWriter(
                writer,
                _options);
            jsonWriter.WriteStartObject();

            jsonWriter.WriteString(
                "__typename",
                entityId.Name);

            jsonWriter.WriteString(
                "id",
                (global::System.Guid)entityId.Value);
            jsonWriter.WriteEndObject();
            jsonWriter.Flush();

            return global::System.Text.Encoding.UTF8.GetString(
                writer.GetInternalBuffer(),
                0,
                writer.Length);
        }
    }
}


// PathfinderOfficialApiServiceCollectionExtensions.StrawberryShake.cs
#nullable enable

namespace Microsoft.Extensions.DependencyInjection
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public static partial class PathfinderOfficialApiServiceCollectionExtensions
    {
        public static global::StrawberryShake.IClientBuilder<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.PathfinderOfficialApiStoreAccessor> AddPathfinderOfficialApi(
            this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var serviceCollection = ConfigureClientDefault(
                        sp,
                        strategy);

                    return new ClientServiceProvider(
                        global::Microsoft.Extensions.DependencyInjection.ServiceCollectionContainerBuilderExtensions.BuildServiceProvider(serviceCollection));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => new global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.PathfinderOfficialApiStoreAccessor(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityIdSerializer>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory>>(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.PathfinderOfficialApi>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<ClientServiceProvider>(sp)));

            return new global::StrawberryShake.ClientBuilder<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.PathfinderOfficialApiStoreAccessor>(
                "PathfinderOfficialApi",
                services);
        }

        private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection ConfigureClientDefault(
            global::System.IServiceProvider parentServices,
            global::StrawberryShake.ExecutionStrategy strategy = global::StrawberryShake.ExecutionStrategy.NetworkOnly)
        {
            var services = new global::Microsoft.Extensions.DependencyInjection.ServiceCollection();
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IEntityStore, global::StrawberryShake.EntityStore>(services);
            global::Microsoft.Extensions.DependencyInjection.Extensions.ServiceCollectionDescriptorExtensions.TryAddSingleton<global::StrawberryShake.IOperationStore>(
                services,
                sp => new global::StrawberryShake.OperationStore(global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IEntityStore>(sp)));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton(
                services,
                sp => 
                {
                    var clientFactory = global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Net.Http.IHttpClientFactory>(parentServices);
                    return new global::StrawberryShake.Transport.Http.HttpConnection(() => clientFactory.CreateClient("PathfinderOfficialApi"));
                });

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatById_Feats_Items_Feat>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatById_Feats_Items_FeatFromFeatEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FrequencyEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatById_Feats_Items_Frequency_Frequency>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatById_Feats_Items_Frequency_FrequencyFromFrequencyEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RollableEffectEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatById_Feats_Items_RollableEffect_RollableEffect>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatById_Feats_Items_RollableEffect_RollableEffectFromRollableEffectEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatById_Feats_Items_Traits_Trait>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatById_Feats_Items_Traits_TraitFromTraitEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPage_Feats_Items_Feat>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatsPage_Feats_Items_FeatFromFeatEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatDetailsBlockEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPage_Feats_Items_Details_FeatDetailsBlock>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatsPage_Feats_Items_Details_FeatDetailsBlockFromFeatDetailsBlockEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPage_Races_Items_Race>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetRacesPage_Races_Items_RaceFromRaceEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceSizeEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPage_Races_Items_Size_RaceSize>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetRacesPage_Races_Items_Size_RaceSizeFromRaceSizeEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.RaceRarityEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPage_Races_Items_Rarity_RaceRarity>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetRacesPage_Races_Items_Rarity_RaceRarityFromRaceRarityEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPage_Spells_Items_Spell>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetSpellsPage_Spells_Items_SpellFromSpellEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitById_Traits_Items_Trait>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitById_Traits_Items_TraitFromTraitEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.FeatEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitById_Traits_Items_Feats_Feat>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitById_Traits_Items_Feats_FeatFromFeatEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitById_Traits_Items_Spells_Spell>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitById_Traits_Items_Spells_SpellFromSpellEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.MagicSchoolEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchool>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitById_Traits_Items_Spells_MagicSchool_MagicSchoolFromMagicSchoolEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.SpellTypeEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitById_Traits_Items_Spells_SpellType_SpellType>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitById_Traits_Items_Spells_SpellType_SpellTypeFromSpellTypeEntityMapper>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityMapper<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.TraitEntity, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPage_Traits_Items_Trait>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitsPage_Traits_Items_TraitFromTraitEntityMapper>(services);

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SortEnumTypeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.StringSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.BooleanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ShortSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IntSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.LongSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.FloatSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DecimalSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UrlSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.UuidSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.IdSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateTimeSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.DateSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.ByteArraySerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::StrawberryShake.Serialization.TimeSpanSerializer>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.ActionTypeSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FeatTypeSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.FrequencySortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RollableEffectSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceSizeSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.RaceRaritySortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SpellTypeSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.SavingThrowStatSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.MagicSchoolSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.TraitSortInputInputValueFormatter>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.Serialization.ISerializerResolver>(
                services,
                sp => new global::StrawberryShake.Serialization.SerializerResolver(
                    global::System.Linq.Enumerable.Concat(
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            parentServices),
                        global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::System.Collections.Generic.IEnumerable<global::StrawberryShake.Serialization.ISerializer>>(
                            sp))));

            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatByIdResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatByIdBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatByIdResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatByIdQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatsPageResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetFeatsPageBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetFeatsPageResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetFeatsPageQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetRacesPageResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetRacesPageBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetRacesPageResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetRacesPageQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetSpellsPageResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetSpellsPageBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetSpellsPageResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetSpellsPageQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitByIdResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitByIdBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitByIdResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitByIdQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitsPageResultFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultDataFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultDataFactory<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationRequestFactory>(
                services,
                sp => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery>(sp));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.GetTraitsPageBuilder>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IOperationExecutor<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>>(
                services,
                sp => new global::StrawberryShake.OperationExecutor<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>(
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.Transport.Http.HttpConnection>(sp),
                    () => global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationResultBuilder<global::System.Text.Json.JsonDocument, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.IGetTraitsPageResult>>(sp),
                    global::Microsoft.Extensions.DependencyInjection.ServiceProviderServiceExtensions.GetRequiredService<global::StrawberryShake.IOperationStore>(sp),
                    strategy));
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.GetTraitsPageQuery>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::StrawberryShake.IEntityIdSerializer, global::Silvester.Pathfinder.Official.Web.Graphql.Generated.State.PathfinderOfficialApiEntityIdFactory>(services);
            global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.AddSingleton<global::Silvester.Pathfinder.Official.Web.Graphql.Generated.PathfinderOfficialApi>(services);
            return services;
        }

        private class ClientServiceProvider
            : System.IServiceProvider
            , System.IDisposable
        {
            private readonly System.IServiceProvider _provider;

            public ClientServiceProvider(System.IServiceProvider provider)
            {
                _provider = provider;
            }

            public object? GetService(System.Type serviceType)
            {
                return _provider.GetService(serviceType);
            }

            public void Dispose()
            {
                if (_provider is System.IDisposable d)
                {
                    d.Dispose();
                }
            }
        }
    }
}


// PathfinderOfficialApiStoreAccessor.StrawberryShake.cs
#nullable enable

namespace Silvester.Pathfinder.Official.Web.Graphql.Generated.State
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.1.0.0")]
    public partial class PathfinderOfficialApiStoreAccessor
        : global::StrawberryShake.StoreAccessor
    {
        public PathfinderOfficialApiStoreAccessor(
            global::StrawberryShake.IOperationStore operationStore,
            global::StrawberryShake.IEntityStore entityStore,
            global::StrawberryShake.IEntityIdSerializer entityIdSerializer,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationRequestFactory> requestFactories,
            global::System.Collections.Generic.IEnumerable<global::StrawberryShake.IOperationResultDataFactory> resultDataFactories)
            : base(
                operationStore,
                entityStore,
                entityIdSerializer,
                requestFactories,
                resultDataFactories)
        {
        }
    }
}


